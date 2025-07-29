
import "./App.css";
import  { useEffect, useState } from "react";
import TaskForm from "./components/taskForm";
import TaskList from "./components/taskList";
import { getTasks, createTask } from "./services/taskService";

function App() {
  const [tasks, setTasks] = useState([]);
  useEffect(() => {
    loadTasks();
  }, []);

  const loadTasks = async () => {
    try {
      const data = await getTasks();
      setTasks(data);
    } catch (err) {
      console.error(err);
    }
  };

  const handleCreateTask = async (task) => {
    try {
      const newTask = await createTask(task);
      setTasks((prev) => [...prev, newTask]);
    } catch (err) {
      console.error(err);
    }
  };

return (
    <div className="container">
      <h1>Task Tracker</h1>
      <TaskForm onTaskCreated={handleCreateTask} />
      <h2>Tasks</h2>
      <TaskList tasks={tasks} />
    </div>
  );
}

export default App;
