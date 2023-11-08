# EDMA (Extremely Dumb Maze Algorithm)

## Step 1:

Generate a square grid of nodes, e.g.

| **N**    | **N** | **N** | **N** |
|----------|-------|-------|-------|
| **N**    | **N** | **N** | **N** |
| **N**    | **N** | **N** | **N** |
| **N**    | **N** | **N** | **N** |

## Step 2:

Place the maze "hubs" randomly throughout the grid, must be at least 1 node apart.

| **H** | **N** | **N** | **N** |
|-------|-------|-------|-------|
| **N** | **N** | **H** | **N** |
| **N** | **N** | **N** | **N** |
| **N** | **H** | **N** | **N** |

## Step 3:

Assign each of the hubs randomly, e.g. starter hub, item hub, enemy spawn, etc.

| **SH** | **N**  | **N**  | **N** |
|--------|--------|--------|-------|
| **N**  | **N**  | **IH** | **N** |
| **N**  | **N**  | **N**  | **N** |
| **N**  | **EH** | **N**  | **N** |

## Step 4:

Randomly remove a node from the grid until a path from the starter hub to each of the other hubs is no longer possible.

| **SH** |        | **N**  | **N** |
|--------|--------|--------|-------|
|        | **N**  | **IH** | **N** |
| **N**  | **N**  |        |       |
| **N**  | **EH** | **N**  | **N** |

(Remember the last node removed)

## Step 5:

Add back the last node removed so that a path from the starter hub to every other hub is possible again.

| **SH** | **N**  | **N**  | **N** |
|--------|--------|--------|-------|
|        | **N**  | **IH** | **N** |
| **N**  | **N**  |        |       |
| **N**  | **EH** | **N**  | **N** |

## Step 6:

We have our maze! Fill in each node with a dungeon block with the appropriate amount of doors.
For example, here's the node in the top right,

|          |          |     |
|----------|----------|-----|
| **Door** | Node     |     |
|          | **Door** |     |