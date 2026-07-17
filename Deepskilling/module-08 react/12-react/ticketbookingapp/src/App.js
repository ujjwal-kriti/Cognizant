import React, { useState } from "react";
import GuestPage from "./Components/GuestPage";
import UserPage from "./Components/UserPage";

function App() {
  const [loggedIn, setLoggedIn] = useState(false);

  return (
    <div style={{ margin: "40px" }}>
      {loggedIn ? (
        <>
          <UserPage />
          <button onClick={() => setLoggedIn(false)}>
            Logout
          </button>
        </>
      ) : (
        <>
          <GuestPage />
          <button onClick={() => setLoggedIn(true)}>
            Login
          </button>
        </>
      )}
    </div>
  );
}

export default App;