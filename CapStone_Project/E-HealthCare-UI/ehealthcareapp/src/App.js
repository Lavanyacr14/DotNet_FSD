import logo from './logo.svg';
import './App.css';
import UserLogin from './components/UserLogin/UserLogin';
import UserRegister from './components/UserRegister/UserRegister';
import Product from './components/Product/Product';
import NewProduct from './components/NewProduct/NewProduct';
import {BrowserRouter, Routes, Route} from "react-router-dom";

function App() {
  return (    
    <BrowserRouter>
    <Routes>
      <Route path='/' element={<UserLogin/>}/>
      <Route path='UserRegister' element={<UserRegister/>}/>
      <Route path='Product' element={<Product/>}/>
      <Route path='NewProduct' element={<NewProduct/>}/>
    </Routes>
    
    </BrowserRouter>   
  );
}

export default App;
