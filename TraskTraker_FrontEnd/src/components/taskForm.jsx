import { useState } from "react";

function TaskForm({ onTaskCreated }) {
  const [name, setName] = useState("");
  const [description, setDescription] = useState("");
  const [error, setError] = useState("");

  const handleSubmit = async (e) => {
    e.preventDefault();

    if (!name.trim()) {
      setError("Task name is required.");
      return;
    }

    setError("");
    await onTaskCreated({ name, description });
    setName("");
    setDescription("");
  };

  return (
    <form onSubmit={handleSubmit}>
      <input
        type="text"
        placeholder="Task name"
        value={name}
        onChange={(e) => setName(e.target.value)}
        required
      />
      <br />
      {error && (
        <span style={{ color: "red", fontSize: "0.9rem" }}>{error}</span>
      )}
      <textarea
        placeholder="Description"
        value={description}
        onChange={(e) => setDescription(e.target.value)}
        required
      />
      <br />
      <button type="submit">Add Task</button>
    </form>
  );
}

export default TaskForm;
