import logo from './logo.svg';
import './App.css';
import UserLogin from './components/UserLogin/UserLogin';
import UserRegister from './components/UserRegister/UserRegister';
import {BrowserRouter, Routes, Route} from "react-router-dom";

function App() {
  return (    
    <BrowserRouter>
    <Routes>
      <Route path='/' element={<UserLogin/>}/>
      <Route path='UserRegister' element={<UserRegister/>}/>
    </Routes>
    
    </BrowserRouter>   
  );
}

export default App;
