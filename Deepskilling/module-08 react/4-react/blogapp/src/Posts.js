import React, { Component } from 'react';
import Post from './Post';

class Posts extends Component {
  constructor(props) {
    super(props);
    this.state = { posts: [], error: null };
    this.loadPosts = this.loadPosts.bind(this);
  }

  async loadPosts() {
    try {
      const res = await fetch('https://jsonplaceholder.typicode.com/posts');
      if (!res.ok) throw new Error('Failed to fetch posts');
      const data = await res.json();
      // limit to first 10 for display
      this.setState({ posts: data.slice(0, 10) });
    } catch (err) {
      this.setState({ error: err });
      throw err;
    }
  }

  componentDidMount() {
    this.loadPosts().catch(() => {});
  }

  componentDidCatch(error, info) {
    // display alert and capture error in state
    alert('An error occurred in Posts component: ' + (error && error.message ? error.message : error));
    this.setState({ error });
  }

  render() {
    const { posts, error } = this.state;
    if (error) {
      return (
        <div style={{textAlign: 'center', padding: 24}}>
          <h2 style={{color: '#b22222'}}>Error loading posts</h2>
          <p>{error.message}</p>
        </div>
      );
    }

    return (
      <div style={{maxWidth: 800, margin: '40px auto', fontFamily: "'Segoe UI', Tahoma, Geneva, Verdana, sans-serif"}}>
        <h1 style={{textAlign: 'center', color: '#b22222'}}>Blog Posts</h1>
        <div style={{boxShadow: '0 0 0 rgba(0,0,0,0)', marginTop: 8}}>
          {posts.map((p) => (
            <Post key={p.id} title={p.title} body={p.body} />
          ))}
        </div>
      </div>
    );
  }
}

export default Posts;
