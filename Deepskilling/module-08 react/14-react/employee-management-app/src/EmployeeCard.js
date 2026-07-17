import React, { useContext } from "react";
import ThemeContext from "./ThemeContext";

function EmployeeCard({ employee }) {
  const theme = useContext(ThemeContext);

  return (
    <div
      style={{
        border: "1px solid gray",
        margin: "10px",
        padding: "10px",
      }}
    >
      <h2>{employee.name}</h2>

      <p>{employee.designation}</p>

      <button
        className={theme}
        style={{
          backgroundColor:
            theme === "light" ? "#2196F3" : "#333",
          color: "white",
          padding: "8px 15px",
          border: "none",
        }}
      >
        View Profile
      </button>
    </div>
  );
}

export default EmployeeCard;