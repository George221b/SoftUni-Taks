<h1>Exercises: Async Programming and Promises</h1>
<p>Problems for exercises and homework for the <a href="https://softuni.bg/courses/javascript-applications">&ldquo;JavaScript Applications&rdquo; course @ SoftUni</a>. Submit your solutions in the SoftUni judge system at <a href="https://judge.softuni.bg/Contests/360/">https://judge.softuni.bg/Contests/360/</a>.</p>
<h2>1.&nbsp;&nbsp; Github Commits</h2>
<p>Write a JS program that loads all commit messages and their authors from a github repository using a given HTML.</p>
<h3>HTML Template</h3>
<p>You are given the following HTML:</p>
<table width="1361">
<tbody>
<tr>
<td width="1361">
<p>commits.html</p>
</td>
</tr>
<tr>
<td width="1361">
<p>&lt;!DOCTYPE <strong>html</strong>&gt;<br /> &lt;<strong>html </strong><strong>lang=</strong><strong>"en"</strong>&gt;<br /> &lt;<strong>head</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>meta </strong><strong>charset=</strong><strong>"UTF-8"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>title</strong>&gt;Github Commits&lt;/<strong>title</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>script </strong><strong>src=</strong><strong>"https://code.jquery.com/jquery-3.1.1.min.js"</strong>&gt;&lt;/<strong>script</strong>&gt;<br /> &lt;/<strong>head</strong>&gt;<br /> &lt;<strong>body</strong>&gt;<br /> GitHub username:<br /> &lt;<strong>input </strong><strong>type=</strong><strong>"text" </strong><strong>id=</strong><strong>"username" </strong><strong>value=</strong><strong>"nakov" </strong>/&gt; &lt;<strong>br</strong>&gt;<br /> Repo: &lt;<strong>input </strong><strong>type=</strong><strong>"text" </strong><strong>id=</strong><strong>"repo" </strong><strong>value=</strong><strong>"nakov.io.cin" </strong>/&gt;<br /> &lt;<strong>button </strong><strong>onclick=</strong><strong>"</strong><em>loadCommits</em>()<strong>"</strong>&gt;Load Commits&lt;/<strong>button</strong>&gt;<br /> &lt;<strong>ul </strong><strong>id=</strong><strong>"commits"</strong>&gt;&lt;/<strong>ul</strong>&gt;<br /> &lt;<strong>script</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; <strong>function </strong><em>loadCommits</em>() {<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <em>// AJAX call &hellip; <br /> &nbsp;&nbsp;&nbsp; </em>}<br /> &lt;/<strong>script</strong>&gt;<br /> &lt;/<strong>body</strong>&gt;<br /> &lt;/<strong>html</strong>&gt;</p>
</td>
</tr>
</tbody>
</table>
<p>The loadCommits function should get the username and repository from the HTML textboxes with ids "username" and "repo" and make a GET request to the Github API:<br /> <strong>"https://api.github.com/repos/&lt;username&gt;/&lt;repository&gt;/commits"</strong></p>
<p>Swap &lt;username&gt; and &lt;repository&gt; with the ones from the HTML:&middot;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; In case of success, for each entry, add a list item (li) in the unordered list (ul) with id= "commits" with text in the format:<br /> "&lt;commit.author.name&gt;: &lt;commit.message&gt;"</p>
<ul>
<li>In case of error and a single list item (li) with text in the format:<br /> "Error: &lt;error.status&gt; (&lt;error.statusText&gt;)"</li>
</ul>
<h3>Screenshots:</h3>
<p>Submit in the Judge only the loadCommits function.</p>
<h2>2.&nbsp;&nbsp; Blog</h2>
<p>Write a JS program for reading blog content. It needs to make requests to the server and display all blog posts and their comments. Use the following HTML to test your solution:</p>
<table width="1361">
<tbody>
<tr>
<td width="1361">
<p>blog.html</p>
</td>
</tr>
<tr>
<td width="1361">
<p>&lt;!DOCTYPE <strong>html</strong>&gt;</p>
<p>&lt;<strong>html</strong>&gt;</p>
<p>&lt;<strong>head</strong>&gt;</p>
<p>&nbsp; &lt;<strong>meta </strong><strong>charset=</strong><strong>"UTF-8"</strong>&gt;</p>
<p>&nbsp; &lt;<strong>title</strong>&gt;Blog&lt;/<strong>title</strong>&gt;</p>
<p>&nbsp; &lt;<strong>script </strong><strong>src=</strong><strong>"https://code.jquery.com/jquery-3.1.1.min.js"</strong>&gt;&lt;/<strong>script</strong>&gt;</p>
<p>&lt;/<strong>head</strong>&gt;</p>
<p>&lt;<strong>body</strong>&gt;</p>
<p>&lt;<strong>h1</strong>&gt;All Posts&lt;/<strong>h1</strong>&gt;</p>
<p>&lt;<strong>button </strong><strong>id=</strong><strong>"btnLoadPosts"</strong>&gt;Load Posts&lt;/<strong>button</strong>&gt;</p>
<p>&lt;<strong>select </strong><strong>id=</strong><strong>"posts"</strong>&gt;&lt;/<strong>select</strong>&gt;</p>
<p>&lt;<strong>button </strong><strong>id=</strong><strong>"btnViewPost"</strong>&gt;View&lt;/<strong>button</strong>&gt;</p>
<p>&lt;<strong>h1 </strong><strong>id=</strong><strong>"post-title"</strong>&gt;Post Details&lt;/<strong>h1</strong>&gt;</p>
<p>&lt;<strong>ul </strong><strong>id=</strong><strong>"post-body"</strong>&gt;&lt;/<strong>ul</strong>&gt;</p>
<p>&lt;<strong>h2</strong>&gt;Comments&lt;/<strong>h2</strong>&gt;</p>
<p>&lt;<strong>ul </strong><strong>id=</strong><strong>"post-comments"</strong>&gt;&lt;/<strong>ul</strong>&gt;</p>
<p>&lt;<strong>script </strong><strong>src=</strong><strong>"solution.js"</strong>&gt;&lt;/<strong>script</strong>&gt;</p>
<p>&lt;<strong>script</strong>&gt;</p>
<p>&nbsp; <em>attachEvents</em>();</p>
<p>&lt;/<strong>script</strong>&gt;</p>
<p>&lt;/<strong>body</strong>&gt;</p>
<p>&lt;/<strong>html</strong>&gt;</p>
</td>
</tr>
</tbody>
</table>
<p>Submit only the attachEvents() function that attaches events to the buttons and contains all program logic. You will need to create a <strong>Kinvey</strong> database to test your code (instructions bellow).</p>
<p>The button with ID "<strong>btnLoadPosts</strong>" should make a GET request to "<strong>/posts</strong>". The response from the server will be an <strong>array</strong> of objects with format:</p>
<p>{ _id: "postId",</p>
<p>&nbsp; title: "postTitle",</p>
<p>&nbsp; body: "postContent" }</p>
<p>Create an &lt;option&gt; for each post using its _id as value and title as text inside the node with ID "<strong>posts</strong>".</p>
<p>&nbsp;</p>
<p>When the button with ID "<strong>btnViewPost</strong>" is clicked should make a GET request to "<strong>/posts/{postId}</strong>" to obtain just the selected post (from the dropdown menu with ID "<strong>posts</strong>") and another request to "<strong>/comments/?query={"post_id":"{postId}"}</strong>" to obtain all comments (replace highlighted parts with the relevant value). The first request will return a single object as described above, while the second will return an array of objects with format:</p>
<p>{ _id: "commentId",</p>
<p>&nbsp; text: "commentCOntent",</p>
<p>&nbsp; post_id: "postId"}</p>
<p>Display the post title inside "#post-title" and the post content inside "#post-body". Display each comment as a &lt;li&gt; inside "#post-comments" and don&rsquo;t forget to clear its contents beforehand.</p>
<p>&nbsp;</p>
<h3>Hints</h3>
<p>To create a Kinvey database with the required content, you need to register an account and create a new backend app.</p>
<p>Create a user and a password. You will need these, along with your <strong>app ID</strong> to authenticate with the server from your JS program.</p>
<p>Use the following POST request trough Postman to create blog posts:</p>
<p>Note the <strong>empty line</strong> between the header and the content, the request won&rsquo;t work without it. Replace the highlighted parts with the relevant info. The authorization string is your <strong>username</strong> and <strong>password</strong> appended together with a <strong>colon</strong> between them as string, hashed with the btoa() function (built into the browser). The resulting post will have an _id automatically assigned by Kinvey. You will then use this ID when creating comments for each blog post.</p>
<p>After the posts and comments are created, your database should look like this:</p>
<p>&nbsp;</p>