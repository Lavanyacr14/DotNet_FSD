import logo from './logo.svg';
import './App.css';
import ToDoList from './components/ToDoList/ToDoList';
import NewTodo from './components/NewTodo/NewTodo';
import {BrowserRouter, Routes, Route} from "react-router-dom";

function App() {
  return (
    <BrowserRouter>
    <Routes>
      <Route path='/' element={<ToDoList/>}/>
      <Route path='newTodo' element={<NewTodo/>}/>
    </Routes>
    
    </BrowserRouter>
  );
}

export default App;
