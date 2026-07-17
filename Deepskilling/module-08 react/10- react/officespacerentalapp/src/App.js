import React from "react";
import office from "./office.jpg";

function App() {
  const offices = [
    {
      Name: "DBS",
      Rent: 50000,
      Address: "Chennai",
      Image: office,
    },
  
    {
      Name: "SmartWorks",
      Rent: 45000,
      Address: "Hyderabad",
      Image: office,
    },
  ];

  return (
    <div style={{ marginLeft: "120px" }}>
      <h1>Office Space, at Affordable Range</h1>

      {offices.map((item, index) => (
        <div key={index} style={{ marginBottom: "30px" }}>
          <img
            src={item.Image}
            alt="Office"
            width="250"
            height="180"
          />

          <h1>Name: {item.Name}</h1>

          <h3
            style={{
              color: item.Rent <= 60000 ? "red" : "green",
            }}
          >
            Rent: Rs. {item.Rent}
          </h3>

          <h3>Address: {item.Address}</h3>
        </div>
      ))}
    </div>
  );
}

export default App;