import EmployeeCard from "./EmployeeCard";

function EmployeesList(props) {

    return (

        <div>

            {

                props.employees.map((employee) => (

                    <EmployeeCard

                        key={employee.id}

                        employee={employee}

                    />

                ))

            }

        </div>

    );

}

export default EmployeesList;