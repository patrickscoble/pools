import React from 'react';

export const Header = () => {

  const headerStyle = {
    width: '100%',
    padding: '2%',
    backgroundColor: "#ADD8E6",
    color: 'black',
    textAlign: 'center',
    marginBottom: '5px'
  }

  return (
    <div style={headerStyle}>
      <h1>Pools</h1>
      <h4>C#/.NET Coding Challenge</h4>
    </div>
  )
}
