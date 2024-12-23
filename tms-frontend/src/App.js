import './App.css';
import LogIn from './Components/Authorization/Login';
import {BrowserRouter as Router, Route, Routes } from 'react-router-dom';
import ProductionOperator from './Components/Authorization/ProductionOperator';
import QualitySupervisor from './Components/Authorization/QualitySupervisor';
import BusinessUnitLeader from './Components/Authorization/BussinesUnitLeader';

function App() {
  return (
    <main className="App">
    <Router>
     <Routes>
       
      
       <Route path='/' element={<LogIn />} />
       <Route path='/ProductionOperator' element={<ProductionOperator />} />
       <Route path='/QualitySupervisor' element={<QualitySupervisor />} />
       <Route path='/BusinessUnitLeader' element={<BusinessUnitLeader />} />

     </Routes>
   </Router>
 </main>
  );
}
export default App;
