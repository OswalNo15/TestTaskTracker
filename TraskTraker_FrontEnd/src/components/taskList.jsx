
function TaskList({ tasks }) {
  if (tasks.length === 0) {
    return <p>No tasks available</p>;
  }

  return (
    <ul>
      {tasks.map(task => (
        <li key={task.id}>
          <strong>{task.name}</strong>: {task.description}
        </li>
      ))}
    </ul>
  );
}

export default TaskList;