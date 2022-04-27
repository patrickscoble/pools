export async function getAllPoolsAsync() {
  const response = await fetch('/api/pool');
  return await response.json();
}

export async function getTotalCostAsync() {
  const response = await fetch('/api/pool/getTotalCost');
  return await response.json();
}
