import {useParams} from "react-router-dom";
import Trainers from "../TrainersMock";

function TrainerDetails(){

const {id}=useParams();

const trainer=Trainers.find(
t=>t.id===parseInt(id)
);

return(

<div>

<h2>Trainer Details</h2>

<p><b>ID:</b> {trainer.id}</p>

<p><b>Name:</b> {trainer.name}</p>

<p><b>Email:</b> {trainer.email}</p>

<p><b>Phone:</b> {trainer.phone}</p>

<p><b>Technology:</b> {trainer.technology}</p>

<p><b>Skills:</b> {trainer.skills}</p>

</div>

);

}

export default TrainerDetails;