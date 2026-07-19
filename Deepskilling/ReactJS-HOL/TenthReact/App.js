import React from "react";
import "./App.css";
import officeImage from "./officeimage.png";

function App() {

  const office = {
    Name: "DBS",
    Rent: 50000,
    Address: "Chennai"
  };

  return (

    <div className="container">

      <h1>Office Space , at Affordable Range</h1>

      <img
        src={officeImage}
        alt="Office Space"
      />

      <h2>Name: {office.Name}</h2>

      <h3
        style={{
          color: office.Rent < 60000 ? "red" : "green"
        }}
      >
        Rent: Rs. {office.Rent}
      </h3>

      <h3>Address: {office.Address}</h3>

    </div>

  );

}

export default App;