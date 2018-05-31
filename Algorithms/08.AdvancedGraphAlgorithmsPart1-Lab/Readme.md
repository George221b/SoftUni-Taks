<h1>Exercises: Minimum Spanning Tree; Shortest Paths</h1>
<p>This document defines the <strong>in-class exercises</strong> assignments for the <a href="https://softuni.bg/opencourses/algorithms">"Algorithms" course @ Software University</a>.</p>
<p>For the following exercises you are given a Visual Studio solution "<strong>Advanced-Graph-Algorithms-Lab</strong>" holding portions of the source code + unit tests. You can download it from the course&rsquo;s page.</p>
<h1>Part I &ndash; Minimum Spanning Tree (MST) &ndash; Kruskal&rsquo;s Algorithm</h1>
<p>If we have a weighted undirected graph we can extract a sub-graph where all nodes (vertices) of the original graph are connected by edges without any cycles. This is referred to as a <strong>spanning tree</strong>. A <strong>minimum spanning tree (MST)</strong> is the spanning tree with the smallest weight (several MST could exist in some graphs).</p>
<p>For example, a cable operator wants to connect its customers to a <strong>cable network</strong>. The homes of the customers are connected by streets (edges) with different lengths (weights). To find out how to connect all homes to its network most efficiently (least distance covered) you need to find the <strong>MST</strong>.</p>
<p>One simple algorithm to find the MST of given graph is <a href="https://en.wikipedia.org/wiki/Kruskal%27s_algorithm"><strong>Kruskal&rsquo;s algorithm</strong></a>. Example:</p>
<table>
<tbody>
<tr>
<td width="516">
<p><strong>Graph</strong></p>
</td>
<td width="330">
<p><strong>Output</strong></p>
</td>
<td width="544">
<p><strong>MST</strong></p>
</td>
</tr>
<tr>
<td width="516">&nbsp;</td>
<td width="330">
<p>Minimum spanning forest weight: 49</p>
<p>(3 5) -&gt; 2</p>
<p>(0 8) -&gt; 5</p>
<p>(1 7) -&gt; 7</p>
<p>(6 8) -&gt; 7</p>
<p>(1 4) -&gt; 8</p>
<p>(3 6) -&gt; 8</p>
<p>(2 6) -&gt; 12</p>
</td>
<td width="544">&nbsp;</td>
</tr>
</tbody>
</table>
<h2>Problem 1.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Run the Unit Test to Make Sure They Initially Fail</h2>
<p>Run the unit tests in the <strong>Kruskal.Tests</strong> project. Since we haven&rsquo;t written the algorithm yet, so they should all fail:</p>
<h2>Problem 2.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Class Edge</h2>
<p>In a weighted graph an edge holds a lot of information &ndash; it connects two nodes, one being the source and the other &ndash; the destination, and also has a weight. To simplify our work, we need a class Edge to hold this info. We can implement IComparable&lt;Edge&gt; in order to compare edges by weight. We can also override ToString() to be able to print an edge in a human-readable way. Assuming all weights are integers, we&rsquo;ve added an implementation of the Edge class to the skeleton:</p>
<h2>Problem 3.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Start with a Hardcoded Example</h2>
<p>In the <strong>KruskalMain</strong> class you&rsquo;re provided with a test case &ndash; a graph with 9 nodes and 11 edges kept in a list of edges. Your task is to complete the Kruskal() method in the <strong>KruskalAlgorithm</strong> class, which receives the number of nodes of the graph and the list of edges and returns a new list of edges representing the minimum spanning tree.</p>
<p>This is how this graph looks like:</p>
<h2>Problem 4.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Sort Edges</h2>
<p>Kruskal&rsquo;s algorithm works by taking all edges in turn, each time the one with smallest weight is picked. Having implemented IComparable&lt;Edge&gt;, we can simply sort the list of edges, calling the Sort() method of the list.</p>
<h2>Problem 5.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Preventing Cycles &ndash; Concept</h2>
<p>Kruskal&rsquo;s algorithm is simple &ndash; having the sorted edges, we take each one in turn, check whether it causes a cycle if added to the current MST and if not &ndash; we add it to the MST. How do we check for cycles though?</p>
<p>The algorithm works by taking the sorted edges and building the tree from scratch. In a tree, we have a root node and descendants; each descendant has a parent. Consider the following graph:</p>
<p>We have three edges. Following the format described in the Edge class, <strong>(startNode endNode) -&gt; weight</strong>, these are:</p>
<ul>
<li>(1 2) -&gt; 7</li>
<li>(1 0) -&gt; 8</li>
<li>(0 2) -&gt; 10</li>
</ul>
<p>At first, the tree is empty, so none of the nodes have parents. We begin by taking the first node, (1 2) -&gt; 7.</p>
<p>Obviously, there are no cycles when adding the first edge. However, we now have a tree with two nodes, we need to mark one of the nodes as parent and the other as child. It doesn&rsquo;t matter which will be which, so let&rsquo;s say that 1 is parent of 2.</p>
<p>Next, we take the edge (1 0) -&gt; 8.</p>
<p>0 has no parent and neither has 1. We can add the edge to the MST. Again, we have to mark which node is the parent. Let&rsquo;s say 1 is the parent again.</p>
<p>In the final step, we take (0 2) -&gt; 10. This will obviously cause a cycle, but how do we tell? We compare parents for the two nodes of the edge, if they are the same, this means there is a cycle. The parent of 0 is 1; the parent of 2 is also 1, therefore we have a cycle and skip this edge.</p>
<p>What if we chose 0 to be parent of 1 during step 2? When considering the final edge, 0 has no parent. The parent of 2 is 1, but the parent of 1 is 0, therefore 2 is descendant of 0.</p>
<p>In essence, we go up the tree following the parents of each node until we reach the <strong>root</strong>. We <strong>compare the roots for both nodes of an edge and if they have the same root then we have a cycle</strong>.</p>
<p>If we have two trees and add a node that connects them, how do we merge the trees? Consider the following example where we have added to the MST two edges (0 1) -&gt; 8 and (2 3) -&gt; 4. We&rsquo;ve marked that 0 is parent (in this case also root node) of 1 and 2 is parent (root node) of 3. When we add (1 3) -&gt; 11 which doesn&rsquo;t cause a cycle, we need to set parents in such a way that the tree will have a single root.</p>
<p>Having the two roots, 0 and 2, of the nodes from the newly added edge, we can just mark one as parent of the other, e.g. mark that 0 is parent of 2. This means that, later on, when checking any of the four nodes, they will all have a single root - 0. 0, 1 and 2 all have 0 as parent; 3 has 2 as parent which has 0 as parent, so the root of 3 is also 0. Therefore, <strong>when adding a new edge to the MST, we need to mark one of the roots as parent of the other.</strong></p>
<h2>Problem 6.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Keeping Track of Parents - Setup</h2>
<p>In a tree, a node can have at most one parent, therefore, we can keep information about each node&rsquo;s parent in an array. To mark that a node has no parent, we can simply say that the node is its own parent. Initializing the array is trivial:</p>
<p>When adding an edge to the MST we&rsquo;ll mark one of the nodes as parent of the other node.</p>
<h2>Problem 7.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; FindRoot() Method - Implementation</h2>
<p>We saw that when taking an edge, we need to find the roots for both nodes. We&rsquo;ll need a method to find the root of a given node.</p>
<p>Finding the root is pretty easy. If the node is its own parent, then it is the root. If the node has a different parent, we go to the parent and check again; we repeat until we find the root. We need to traverse the parent[] array until we reach an element which has equal index and value:</p>
<p>Note that if we have a forest to start with, we&rsquo;ll have one root per connected component. The FindRoot() method and the algorithm itself will still work correctly.</p>
<h2>Problem 8.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Kruskal&rsquo;s Algorithm &ndash; Implementation</h2>
<p>Having the sorted edges and a way to prevent cycles, it&rsquo;s time to implement the algorithm itself.</p>
<p>It&rsquo;s pretty simple: 1) instantiate a list to hold the edges of the MST; 2) traverse all edges; 3) find the roots for both nodes in an edge; 4) if the roots are different &ndash; add the edge to the MST and mark one node as parent of the other.</p>
<p>Complete the TODOs in the code below:</p>
<p>Once you&rsquo;re done, run the program. It should produce the following result:</p>
<p>And this is the result visually:</p>
<h2>Problem 9.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Run the Unit Tests Again</h2>
<p>This time all tests should pass:</p>
<p>We&rsquo;re not done yet though. We can optimize things a bit.</p>
<h2>Problem 10. &nbsp;FindRoot() &ndash; Path Compression</h2>
<p>Perhaps you&rsquo;ve noticed that when searching for the root of a given node we always move up the tree one step at a time. This isn&rsquo;t really necessary though. In a tree, the root is only one and we can mark that it&rsquo;s the parent of all its descendants, so, instead of climbing each node in succession, we can go straight to the root. This is what&rsquo;s called path compression.</p>
<p>We need to modify the FindRoot() method. Once we find the root, we&rsquo;ll mark it as parent for all nodes we&rsquo;ve traversed in order to find it. Start with the node we were given initially and move up until we reach the root, making the root a parent for all nodes we move through along the way:</p>
<h2>Problem 11. Run the Unit Tests One Last Time</h2>
<p>Make sure the algorithm still works. Running the unit tests after each change we make ensures we don&rsquo;t break the code while trying to fix or improve it. The tests should still pass.</p>
<p>You&rsquo;ve successfully implemented Kruskal&rsquo;s algorithm!</p>
<h1>Part II &ndash; Dijkstra&rsquo;s Shortest Path Algorithm</h1>
<p>Finding the <strong>shortest path between two nodes</strong> in an unweighted graph is done by applying simple BFS. When we&rsquo;re working with weighted graphs though, things get more complicated. <strong>Dijkstra&rsquo;s algorithm</strong> is one of the most famous ones that solves this task.</p>
<p>A classical application of the shortest path algorithm might be to find the shortest path between two towns on a map holding towns connected with roads where each road holds the distance between two towns.</p>
<p>Example: Find the shortest path between <strong>node 0</strong> and <strong>node 9</strong> in the following weighted undirected graph:</p>
<p>The result is: 0-&gt;8-&gt;5-&gt;4-&gt;11-&gt;1-&gt;9 (length 42).</p>
<h2>Problem 12. Provided Assets</h2>
<p>In the <strong>Dijkstra</strong> project you are provided with a test case in the Main() method and a method for printing the shortest path between two vertices.</p>
<p>The graph is given as a square matrix where the indices of the rows and columns represent nodes; each cell represents the weight of the edge between two nodes &ndash; the row and the column. If the cell has value of 0 this means that there is no edge connecting the two nodes (or the row and column indices are the same).</p>
<h2>Problem 13. Run the Unit Tests to Make Sure They Initially Fail</h2>
<p>The algorithm is still not implemented, so all unit tests should fail:</p>
<h2>Problem 14. Initialize Distances</h2>
<p>We need an array to hold the minimum distance to each node. Initially, the distance to the source node is 0 and the distance to all other nodes is set to infinity (or, in our case, the maximal value for the int type):</p>
<h2>Problem 15. Initialize the previous[] and used[] arrays</h2>
<p>We also need to keep track of the nodes we&rsquo;ve visited and, in order to reconstruct the path later, the previous node. The source node has no previous, the value for it will be <strong>null</strong>, so we need a <strong>nullable</strong> type:</p>
<h2>Problem 16. Find Nearest Unvisited Node</h2>
<p>The next steps take place in a loop &ndash; we find the nearest unvisited node and start from there. When all possible nodes are traversed, we&rsquo;ll break the loop:</p>
<p>Finding the nearest unvisited node is simple &ndash; loop through all nodes; for each node check whether it&rsquo;s been visited (this info is kept in the used[] array), check if the distance between the source node and the current one is smaller than the current shortest distance:</p>
<p>When we&rsquo;re done, if minDistance is still equal to int.MaxValue, this means all possible nodes have been traversed and we need to exit the loop; if not, mark the minNode as visited:</p>
<h2>Problem 17. Improve Shortest Distances</h2>
<p>Using the node we just found, we need to go through all nodes connected to it and improve the shortest distances. A node is connected to another node if there is an edge between them; in the context of our matrix, this means a cell with value greater than 0.</p>
<p>You need to do the following:</p>
<ul>
<li>Loop through each node</li>
<li>Check the ones that are connected to the minNode</li>
<li>Calculate the distance from the source node to the current node &ndash; just add the shortest distance to minNode and the distance between minNode and the node</li>
<li>If the calculated distance is shorter than the current shortest distance for the current node &ndash; update the shortest distance and make minNode the previous element</li>
</ul>
<p>Complete the TODOs in order to improve the shortest distances:</p>
<h2>Problem 18. Reconstruct Shortest Path</h2>
<p>First thing&rsquo;s first &ndash; if the shortest distance to the destination is still infinity then we haven&rsquo;t found a path:</p>
<p>To reconstruct the path, we start from the destination node and move back (using the info kept in the previous[] array) until we reach the source &ndash; the source has no previous, so the value will be null. At each step, add the node to a list. Reverse the list in the end and return it:</p>
<h2>Problem 19. Run the Unit Tests Again</h2>
<p>If you&rsquo;ve completed all tasks correctly, the unit test should now pass:</p>
<p>Congratulations! You&rsquo;ve completed one of the most famous graph algorithms &ndash; Dijkstra&rsquo;s!</p>
<h1>Part III &ndash; *Dijkstra With Priority Queue</h1>
<p>In this problem, we&rsquo;ll try to implement the optimized version of Dijkstra&rsquo;s algorithm using a priority queue.</p>
<p>Example: Find the shortest path between <strong>node 0</strong> and <strong>node 9</strong> in the following weighted undirected graph:</p>
<p>The result is: 0-&gt;8-&gt;5-&gt;4-&gt;11-&gt;1-&gt;9 (length 42).</p>
<h2>Problem 1.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Provided Assets</h2>
<p>In the <strong>Dijkstra</strong> project you are provided with a test case in the Main() method and a method for printing the shortest path between two vertices.</p>
<p>The graph is given as an incidence list (a collection of nodes and for each node it&rsquo;s connected edges) represented as two nested dictionaries (Dictionary&lt;Node, Dictionary&lt;Node, int&gt;) where the keys of the first dictionary represent the nodes and the inner dictionary represents the edges &ndash; it&rsquo;s keys being the child nodes and it&rsquo;s values being the distances. We&rsquo;re also provided with an extra collection Dictionary &lt;int , Node&gt; to give us easy access to a node by its Id.</p>
<p>Run the Unit Tests to Make Sure They Initially Fail</p>
<p>The algorithm is still not implemented, so all unit tests should fail:</p>
<h2>Problem 2.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Create the Node class</h2>
<p>Our graph will use objects of class Node, so first we need to implement the Node class. A node needs to store its Id so we can distinguish them, in our case the Id is a number so we&rsquo;ll need an integer property. A node also needs to hold its distance from the starting point so we&rsquo;ll need a property for that too, since all nodes will start with distance from start equal to infinity, we can just add a default value for the distance in the constructor:</p>
<p>We&rsquo;re also given an implementation of a priority queue with a binary heap, you can examine the implementation if you want, but what is important is that the priority queue provides us with 3 needed commands &ndash; Enqueue, ExtractMin and DecreaseKey.</p>
<p>Enqueue adds a new element to the priority queue, ExtractMin removes the element with the smallest value from the queue and returns it and DecreaseKey decreases the value of an element and reorders the priority queue so the changed element is repositioned in its correct place and the heap property is kept.</p>
<p>It is important to note that in order for the priority queue to function the elements it works with must be comparable, so we have to implement the IComparable interface in our Node class. The value of a node is the distance of that node from the starting node, so when we are comparing two nodes we are actually comparing their distances from the start:</p>
<h2>Problem 3.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Initialize the previous[] and visited[] arrays</h2>
<p>Once we have implemented the Node class, it&rsquo;s time to move on to the algorithm itself. We&rsquo;ll need to keep track of the nodes we&rsquo;ve visited and, in order to reconstruct the path later, the previous node.</p>
<p>We also need a priority queue to hold the nodes we can currently visit, since the nodes are reference types, if we perform multiple searches on the same graph we want the distances to the start to be reset to infinity each time, so we iterate over the nodes and reset their distance to infinity:</p>
<p>After we have initialized the collections we&rsquo;ll need, it&rsquo;s time to set the distance to the source node to 0 and Enqueue it in the priority queue.</p>
<h2>Problem 4.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Find Nearest Node</h2>
<p>The next steps take place in a loop &ndash; we take the nearest node and start from there. When we find the destination node or when all nodes in range are traversed, the loop ends:</p>
<p>For the node we got from the priority queue we need to check all of its neighboring nodes, if we find an unvisited node we add it to the priority queue and mark it as visited, we do this so we won&rsquo;t add the same node twice to the priority queue.</p>
<h2>Problem 5.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Improve Shortest Distances</h2>
<p>For each neighboring node we need to check if we have found a better distance to it, if we have, we change its distance, set the current node as its previous and call the DecreaseKey method.</p>
<p>With this the logic of the algorithm is complete, it is of some interest here to note that in the given implementation we decrease the distance of the neighboring node in our algorithm instead of having the DecreaseKey operation do it, we can do this because the nodes are reference types, in different implementations of priority queues, the priority can be seperated from the elements and be part of the queue and this operation can be done by the DecreaseKey method.</p>
<h2>Problem 6.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Reconstruct Shortest Path</h2>
<p>After the loop finishes its time to check the results, first thing&rsquo;s first &ndash; if the shortest distance to the destination is still infinity then we haven&rsquo;t found a path:</p>
<p>To reconstruct the path, we start from the destination node and move back (using the info kept in the previous[] array) until we reach the source &ndash; the source has no previous, so the value will be null. At each step, add the node to a list. Reverse the list in the end and return it:</p>
<h2>Problem 7.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Run the Unit Tests Again</h2>
<p>If you&rsquo;ve completed all tasks correctly, the unit test should now pass:</p>
<p>Congratulations! You&rsquo;ve implemented the optimized Dijkstra&rsquo;s algorithm using a priority queue!</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>