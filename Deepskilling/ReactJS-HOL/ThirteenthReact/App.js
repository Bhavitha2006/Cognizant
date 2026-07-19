import React from "react";
import "./App.css";

import BookDetails from "./BookDetails";
import BlogDetails from "./BlogDetails";
import CourseDetails from "./CourseDetails";

import {books,blogs,courses} from "./Data";

function App(){

    const show=true;

    return(

        <div className="container">

            <div className="column">

                <h1>Course Details</h1>

                {show ? <CourseDetails courses={courses}/> : null}

            </div>

            <div className="column">

                <h1>Book Details</h1>

                {show && <BookDetails books={books}/>}

            </div>

            <div className="column">

                <h1>Blog Details</h1>

                {show ? <BlogDetails blogs={blogs}/> : null}

            </div>

        </div>

    );

}

export default App;