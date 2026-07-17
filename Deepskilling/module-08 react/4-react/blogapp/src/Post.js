import React from 'react';

export default function Post({ title, body }) {
  return (
    <div style={{borderBottom: '1px solid #eee', padding: 12}}>
      <h3 style={{margin: '6px 0', color: '#2b6cb0'}}>{title}</h3>
      <p style={{margin: '6px 0', color: '#333'}}>{body}</p>
    </div>
  );
}
