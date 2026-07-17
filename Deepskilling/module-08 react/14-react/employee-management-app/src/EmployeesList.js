import React from "react";
import EmployeeCard from "./EmployeeCard";

function EmployeesList() {
  const employees = [
    {
      id: 1,
      name: "John",
      designation: "Software Engineer",
    },
    {
      id: 2,
      name: "Alice",
      designation: "Project Manager",
    },
    {
      id: 3,
      name: "David",
      designation: "Tester",
    },
  ];

  return (
    <div>
      {employees.map((emp) => (
        <EmployeeCard key={emp.id} employee={emp} />
      ))}
    </div>
  );
}

export default EmployeesList;