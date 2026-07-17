import React from "react";
import EventExamples from "./Components/EventExamples";
import CurrencyConvertor from "./Components/CurrencyConvertor";

function App() {
  return (
    <div style={{ margin: "30px" }}>
      <EventExamples />

      <br />

      <CurrencyConvertor />
    </div>
  );
}

export default App;