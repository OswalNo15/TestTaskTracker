const BASE_URL = process.env.REACT_APP_API_URL;
const TASKS_ENDPOINT = `${BASE_URL}/TaskTracker`;


export async function getTasks() {
  const response = await fetch(TASKS_ENDPOINT);
  if (!response.ok) throw new Error("failed to fetch tasks");
  return await response.json();
}

export async function createTask(task) {
  const response = await fetch(TASKS_ENDPOINT, {
    method: "POST",
    headers: { "Content-Type": "application/json" },
    body: JSON.stringify(task),
  });
  if (!response.ok) throw new Error("Failed to create task");
  return await response.json();
}
