import { useContext } from "react";
import ThemeContext from "./ThemeContext";
import styles from "./EmployeeCard.module.css";

function EmployeeCard(props) {

    const theme = useContext(ThemeContext);

    return (

        <div className={styles.card}>

            <h3>{props.employee.Name}</h3>

            <p><b>Designation :</b> {props.employee.Designation}</p>

            <p><b>Salary :</b> {props.employee.Salary}</p>

            <button className={styles[theme]}>

                View Details

            </button>

        </div>

    );

}

export default EmployeeCard;