import React, { Component } from "react";

class EventExamples extends Component {
  constructor(props) {
    super(props);
    this.state = {
      count: 0,
    };
  }

  increment = () => {
    this.setState({ count: this.state.count + 1 });
  };

  decrement = () => {
    this.setState({ count: this.state.count - 1 });
  };

  sayHello = () => {
    alert("Hello! Member1");
  };

  increase = () => {
    this.increment();
    this.sayHello();
  };

  sayWelcome = (msg) => {
    alert(msg);
  };

  onPress = () => {
    alert("I was clicked");
  };

  render() {
    return (
      <div>
        <h3>{this.state.count}</h3>

        <button onClick={this.increase}>Increment</button>
        <br /><br />

        <button onClick={this.decrement}>Decrement</button>
        <br /><br />

        <button onClick={() => this.sayWelcome("welcome")}>
          Say welcome
        </button>
        <br /><br />

        <button onClick={this.onPress}>
          Click on me
        </button>
      </div>
    );
  }
}

export default EventExamples;