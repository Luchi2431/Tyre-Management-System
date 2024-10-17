import logo from './logo.svg';
import './App.css';
import React from 'react';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import Login from './Components/Login';

function App() {
  return (
    <main className="App">
    <Router>
     <Routes>
       <Route path='/' element={<Login />} />
     </Routes>
   </Router>
  
 
 </main>
  );
}


export default App;
