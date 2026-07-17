import React from "react";
import CalculateScore from "./Components/CalculateScore";

function App() {
  return (
    <CalculateScore
      Name="Steve"
      School="DNV Public School"
      Total={284}
      goal={300}
    />
  );
}

export default App;