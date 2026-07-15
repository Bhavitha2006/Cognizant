import React from "react";
import CalculateScore from "./Components/CalculateScore";

function App() {
  return (
    <div>
      <CalculateScore
        Name="Bhavitha"
        School="ABC Public School"
        Total={450}
        Goal={5}
      />
    </div>
  );
}

export default App;