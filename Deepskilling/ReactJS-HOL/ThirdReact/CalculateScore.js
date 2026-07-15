import React from "react";
import "../Stylesheets/mystyle.css";

function CalculateScore(props) {
    const average = props.Total / props.Goal;

    return (
        <div className="box">
            <h2>Student Score Details</h2>

            <p><b>Name:</b> {props.Name}</p>
            <p><b>School:</b> {props.School}</p>
            <p><b>Total Marks:</b> {props.Total}</p>
            <p><b>Subjects:</b> {props.Goal}</p>
            <p><b>Average:</b> {average}</p>
        </div>
    );
}

export default CalculateScore;