import './App.css';
import { EmployeesData } from './Employee';
import EmployeesList from './EmployeesList';
import { useState } from 'react';
import ThemeContext from './ThemeContext';

function App() {

  const Employees = EmployeesData;

  const [theme, setTheme] = useState("light");

  return (

    <ThemeContext.Provider value={theme}>

      <div>

        <label><b>SELECT A THEME </b></label>

        <select
          value={theme}
          onChange={(e) => setTheme(e.target.value)}
        >
          <option value="light">Light</option>
          <option value="dark">Dark</option>
        </select>

        <br /><br />

        <EmployeesList employees={Employees} />

      </div>

    </ThemeContext.Provider>

  );

}

export default App;