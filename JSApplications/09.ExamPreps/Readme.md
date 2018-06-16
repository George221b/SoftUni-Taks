<h1>JS Apps Exam &ndash; SeenIt Single Page Application</h1>
<p>You are assigned to implement a <strong>Web application</strong> (SPA) using HTML5, JavaScript, AJAX, REST and JSON with cloud-based backend (Kinvey). The app keeps <strong>users</strong>, <strong>posts and comments</strong>. Users can <strong>register</strong>, <strong>login</strong>, <strong>logout</strong> , view a <strong>catalog</strong> with all <strong>posts</strong> sorted by <strong>time</strong> (a helper function will be given), <strong>create</strong> a post, <strong>edit/delete</strong> their <strong>own</strong> posts, view a <strong>post</strong> with it&rsquo;s comments, <strong>create</strong> a comment, <strong>delete</strong> their own comments and a <strong>section</strong> where they can view their <strong>own</strong> posts.</p>
<p>Using libraries like <strong>jQuery</strong>, <strong>Handlebars</strong> and <strong>Sammy</strong> is allowed but is not obligatory.</p>
<h2>Problem 1.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Create a Kinvey REST Service</h2>
<p>Register at <strong>Kinvey.com</strong> and create an application to keep your data in the cloud.</p>
<p>In the <strong>Users</strong> collection, import the provided JSON file with sample users to get started with template data. In the <strong>Kinvey Console</strong>, select <strong>Users</strong> from the navigation of the left, click <strong>Settings</strong> in the upper right then scroll down to the <strong>Import</strong> section:</p>
<p>Create a collection <strong>posts</strong>. Each <strong>post</strong> has a <strong>url</strong> (a link to website), <strong>title</strong>, <strong>imageUrl</strong>, <strong>description</strong> and an <strong>author</strong> (username of the author).</p>
<p>Create a collection <strong>comments</strong>. Each comment has <strong>postId</strong>, &nbsp;<strong>content</strong> and <strong>author</strong> (username of the author).</p>
<p>You are also given <strong>two</strong> more json files to <strong>import</strong> data for <strong>posts</strong> and <strong>comments</strong>.</p>
<h2>Problem 2.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Test the Kinvey REST Services</h2>
<p>Using <strong>Postman</strong> or other HTTP client tool (you can use Kinvey&rsquo;s built-in <strong>API Console</strong>), test the REST service endpoints:</p>
<h3>User Registration (Sign Up)</h3>
<table>
<tbody>
<tr>
<td colspan="2" width="1402">
<p><strong>POST</strong> <a href="https://baas.kinvey.com/user/app_id/">https://baas.kinvey.com/user/<strong><em>app_id</em></strong>/</a></p>
</td>
</tr>
<tr>
<td width="261">
<p>Request headers</p>
</td>
<td width="1141">
<p>Authorization: Basic base64(app_id:app_secret)</p>
<p>Content-Type: application/json</p>
</td>
</tr>
<tr>
<td width="261">
<p>Request body</p>
</td>
<td width="1141">
<p>{</p>
<p>&nbsp; "username": "testuser",</p>
<p>&nbsp; "password": "testuserpass890"</p>
<p>}</p>
</td>
</tr>
<tr>
<td width="261">
<p>Response</p>
<p>201 Created</p>
</td>
<td width="1141">
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; "_id": "59930c78a743e20c7d3fca77",</p>
<p>&nbsp;&nbsp;&nbsp; "username": "testuser",</p>
<p>&nbsp; &nbsp;&nbsp;"password": "testuserpass890"</p>
<p>}</p>
</td>
</tr>
<tr>
<td width="261">
<p>Error response</p>
<p>409 Conflict</p>
</td>
<td width="1141">
<p>{ "error": "UserAlreadyExists", "description": "This username is already taken. Please retry your request with a different username",&nbsp; "debug": "" }</p>
</td>
</tr>
<tr>
<td width="261">
<p>Error response</p>
<p>401 Unauthorized</p>
</td>
<td width="1141">
<p>{ "error": "InvalidCredentials", "description": "Invalid credentials. Please retry your request with correct credentials", "debug": "" }</p>
</td>
</tr>
</tbody>
</table>
<p>The request needs &ldquo;<strong>Basic</strong>&rdquo; authentication. Use the Kinvey <strong>App Key</strong> and Kinvey <strong>App Secret</strong> as credentials.</p>
<h3>User Login</h3>
<table>
<tbody>
<tr>
<td colspan="2" width="1402">
<p><strong>POST</strong> <a href="https://baas.kinvey.com/user/app_id/login">https://baas.kinvey.com/user/<strong><em>app_id</em></strong>/login</a></p>
</td>
</tr>
<tr>
<td width="261">
<p>Request headers</p>
</td>
<td width="1141">
<p>Authorization: Basic base64(app_id:app_secret)</p>
<p>Content-Type: application/json</p>
</td>
</tr>
<tr>
<td width="261">
<p>Request body</p>
</td>
<td width="1141">
<p>{</p>
<p>&nbsp; "username": "testuser",</p>
<p>&nbsp; "password": "testuserpass890"</p>
<p>}</p>
</td>
</tr>
<tr>
<td width="261">
<p>Response</p>
<p>200 OK</p>
</td>
<td width="1141">
<p>{</p>
<p>&nbsp; "_id": "59930c78a743e20c7d3fca77",</p>
<p>&nbsp; "username": "testuser"</p>
<p>&nbsp; "_kmd": {</p>
<p>&nbsp;&nbsp;&nbsp; "<strong>authtoken</strong>": "<strong>8e6471bc-3712-4cfb-b92e-50e62a0c80&hellip;.Duj5fHdM /7XHIe6KdY=</strong>"</p>
<p>&nbsp;&nbsp;&nbsp; &hellip;</p>
<p>&nbsp; },</p>
<p>&nbsp; &hellip;</p>
<p>}</p>
</td>
</tr>
<tr>
<td width="261">
<p>Error response</p>
<p>401 Unauthorized</p>
</td>
<td width="1141">
<p>{ "error": "InvalidCredentials", "description": "Invalid credentials. Please retry your request with correct credentials", "debug": "" }</p>
</td>
</tr>
</tbody>
</table>
<p>Successful login returns an &ldquo;<strong>authtoken</strong>&rdquo; which is later used to authenticate the CRUD operations.</p>
<h3>User Logout</h3>
<table>
<tbody>
<tr>
<td colspan="2" width="1402">
<p><strong>POST</strong> <a href="https://baas.kinvey.com/user/app_id/_logout">https://baas.kinvey.com/user/<strong><em>app_id</em></strong>/_logout</a></p>
</td>
</tr>
<tr>
<td width="261">
<p>Request headers</p>
</td>
<td width="1141">
<p>Authorization: Kinvey <strong>authtoken</strong></p>
</td>
</tr>
<tr>
<td width="261">
<p>Response</p>
<p>204 No Content</p>
</td>
<td width="1141">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="261">
<p>Error response</p>
<p>401 Unauthorized</p>
</td>
<td width="1141">
<p>{ "error": "InvalidCredentials", "description": "Invalid credentials. Please retry your request with correct credentials", "debug": "" }</p>
</td>
</tr>
</tbody>
</table>
<p>To logout, you need to provide the &ldquo;<strong>authtoken</strong>&rdquo; given by login / register as &ldquo;<strong>Kinvey</strong>&rdquo; authorization header.</p>
<h3>List all Posts (Catalog &ndash; sorted by post time, descending)</h3>
<table>
<tbody>
<tr>
<td colspan="2" width="1402">
<p><strong>GET</strong> <a href="https://baas.kinvey.com/appdata/app_id/posts">https://baas.kinvey.com/appdata/<strong><em>app_id</em></strong>/posts</a>?query={}&amp;sort={"_kmd.ect": -1}</p>
</td>
</tr>
<tr>
<td width="261">
<p>Request headers</p>
</td>
<td width="1141">
<p>Authorization: Kinvey authtoken</p>
</td>
</tr>
<tr>
<td width="261">
<p>Response</p>
<p>200 OK</p>
</td>
<td width="1141">
<p>[</p>
<p>&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "_id": "599307d36af42b495f87bad2",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "author": "Kiril",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "description": "My GitHub profile",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "url": "https://github.com/k1r1L",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "title": "GitHub",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "imageUrl": "https://pbs.twimg.com/profile_images/616309728688238592/pBeeJQDQ.png",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "_acl": {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "creator": "kid_B1zfi_e_Z"</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "_kmd": {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "lmt": "2017-08-15T14:40:19.182Z",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "ect": "2017-08-15T14:40:19.182Z"</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp;&nbsp;&nbsp; },...</p>
<p>]</p>
</td>
</tr>
<tr>
<td width="261">
<p>Error response</p>
<p>401 Unauthorized</p>
</td>
<td width="1141">
<p>{ "error": "InvalidCredentials", "description": "Invalid credentials. Please retry your request with correct credentials", "debug": "" }</p>
</td>
</tr>
</tbody>
</table>
<h3>Create Post</h3>
<table>
<tbody>
<tr>
<td colspan="2" width="1402">
<p><strong>POST</strong> <a href="https://baas.kinvey.com/appdata/app_id/posts">https://baas.kinvey.com/appdata/<strong><em>app_id</em></strong>/posts</a></p>
</td>
</tr>
<tr>
<td width="261">
<p>Request headers</p>
</td>
<td width="1141">
<p>Authorization: Kinvey authtoken</p>
<p>Content-Type: application/json</p>
</td>
</tr>
<tr>
<td width="261">
<p>Request body</p>
</td>
<td width="1141">
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; "author": "Kiril",</p>
<p>&nbsp;&nbsp;&nbsp; "title": "Test Post",</p>
<p>&nbsp;&nbsp;&nbsp; "description": "Test Post Description",</p>
<p>&nbsp;&nbsp;&nbsp; "url": "https://en.wikipedia.org/wiki/Santorini",</p>
<p>&nbsp;&nbsp;&nbsp; "imageUrl":"http://sailing-santorini.com/wp-content/uploads/2015/10/sunset-oia 500x500.jpg"</p>
<p>}</p>
</td>
</tr>
<tr>
<td width="261">
<p>Response</p>
<p>201 Created</p>
</td>
<td width="1141">
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; "_id": "59931398996ab5127d2a84d1",</p>
<p>&nbsp;&nbsp;&nbsp; "author": "Kiril",</p>
<p>&nbsp;&nbsp;&nbsp; "title": "Test Post",</p>
<p>&nbsp;&nbsp;&nbsp; "description": "Test Post Description",</p>
<p>&nbsp;&nbsp;&nbsp; "url": "https://en.wikipedia.org/wiki/Santorini",&hellip;</p>
<p>}</p>
</td>
</tr>
<tr>
<td width="261">
<p>Error response</p>
<p>401 Unauthorized</p>
</td>
<td width="1141">
<p>{ "error": "InvalidCredentials", "description": "Invalid credentials. Please retry your request with correct credentials", "debug": "" }</p>
</td>
</tr>
</tbody>
</table>
<h3>Edit Post</h3>
<table>
<tbody>
<tr>
<td colspan="2" width="1402">
<p><strong>PUT</strong> <a href="https://baas.kinvey.com/appdata/app_id/posts/post_id">https://baas.kinvey.com/appdata/<strong><em>app_id</em></strong>/posts/<strong>post_id</strong></a></p>
</td>
</tr>
<tr>
<td width="261">
<p>Request headers</p>
</td>
<td width="1141">
<p>Authorization: Kinvey authtoken</p>
<p>Content-Type: application/json</p>
</td>
</tr>
<tr>
<td width="261">
<p>Request body</p>
</td>
<td width="1141">
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; "author": "Kiril",</p>
<p>&nbsp;&nbsp;&nbsp; "title": "Test Post <strong>Edited</strong>",</p>
<p>&nbsp;&nbsp;&nbsp; "description": "Test Post Description <strong>Edited</strong>",</p>
<p>&nbsp;&nbsp;&nbsp; "url": "https://en.wikipedia.org/wiki/Santorini",</p>
<p>&nbsp;&nbsp;&nbsp; "imageUrl":"http://sailing-santorini.com/wp-content/uploads/2015/10/sunset-oia 500x500.jpg"</p>
<p>}</p>
</td>
</tr>
<tr>
<td width="261">
<p>Response</p>
<p>200 Ok</p>
</td>
<td width="1141">
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; "_id": "59931398996ab5127d2a84d1",</p>
<p>&nbsp;&nbsp;&nbsp; "author": "Kiril",</p>
<p>&nbsp;&nbsp;&nbsp; "title": "Test Post <strong>Edited</strong>",</p>
<p>&nbsp;&nbsp;&nbsp; "description": "Test Post Description <strong>Edited</strong>",</p>
<p>&nbsp;&nbsp;&nbsp; "url": "https://en.wikipedia.org/wiki/Santorini",&hellip;</p>
<p>}</p>
</td>
</tr>
<tr>
<td width="261">
<p>Error response</p>
<p>401 Unauthorized</p>
</td>
<td width="1141">
<p>{ "error": "InvalidCredentials", "description": "Invalid credentials. Please retry your request with correct credentials", "debug": "" }</p>
</td>
</tr>
</tbody>
</table>
<h3>Delete Post</h3>
<table>
<tbody>
<tr>
<td colspan="2" width="1402">
<p><strong>DELETE</strong> <a href="https://baas.kinvey.com/appdata/app_id/posts/post_id">https://baas.kinvey.com/appdata/<strong><em>app_id</em></strong>/posts/<strong><em>post_id</em></strong></a></p>
</td>
</tr>
<tr>
<td width="261">
<p>Request headers</p>
</td>
<td width="1141">
<p>Authorization: Kinvey authtoken</p>
</td>
</tr>
<tr>
<td width="261">
<p>Response</p>
<p>200 OK</p>
</td>
<td width="1141">
<p>{</p>
<p>&nbsp; "count": 1</p>
<p>}</p>
</td>
</tr>
<tr>
<td width="261">
<p>Error response</p>
<p>404 Not Found</p>
</td>
<td width="1141">
<p>{ "error": "EntityNotFound", "description": "This entity not found in the collection", "debug": "" }</p>
</td>
</tr>
<tr>
<td width="261">
<p>Error response</p>
<p>401 Unauthorized</p>
</td>
<td width="1141">
<p>{ "error": "InvalidCredentials", "description": "Invalid credentials. Please retry your request with correct credentials", "debug": "" }</p>
</td>
</tr>
</tbody>
</table>
<h3>My Posts (View all posts by logged in user, sorted by post time, descending)</h3>
<table>
<tbody>
<tr>
<td colspan="2" width="1402">
<p><strong>GET </strong><a href="https://baas.kinvey.com/appdata/app_id/posts?query=%7b%22author%22:%22username%22%7d">https://baas.kinvey.com/appdata/<strong>app_id</strong>/posts?query={"author":"<strong>username</strong>"}</a>&amp;sort={"_kmd.ect": -1}</p>
</td>
</tr>
<tr>
<td width="261">
<p>Request headers</p>
</td>
<td width="1141">
<p>Authorization: Kinvey authtoken</p>
</td>
</tr>
<tr>
<td width="261">
<p>Response</p>
<p>200 OK</p>
</td>
<td width="1141">
<p>[</p>
<p>&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "_id": "599307d36af42b495f87bad2",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "author": "Kiril",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "description": "My GitHub profile",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "url": "https://github.com/k1r1L",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "title": "GitHub",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "imageUrl": "https://pbs.twimg.com/profile_images/616309728688238592/pBeeJQDQ.png",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "_acl": {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "creator": "kid_B1zfi_e_Z"</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "_kmd": {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "lmt": "2017-08-15T14:40:19.182Z",</p>
<p>&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;"ect": "2017-08-15T14:40:19.182Z"</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "_id": "5993178dbce993cf532bbe29",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "author": "Kiril",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "title": "Test Post",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "description": "Test Post Description",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "url": "https://en.wikipedia.org/wiki/Santorini",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "imageUrl": "http://sailing-santorini.com/wp-content/uploads/2015/10/sunset-oia-500x500.jpg",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "_acl": {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "creator": "59930c78a743e20c7d3fca77"</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "_kmd": {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "lmt": "2017-08-15T15:47:25.376Z",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "ect": "2017-08-15T15:47:25.376Z"</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp;&nbsp;&nbsp; }</p>
<p>]</p>
</td>
</tr>
<tr>
<td width="261">
<p>Error response</p>
<p>401 Unauthorized</p>
</td>
<td width="1141">
<p>{ "error": "InvalidCredentials", "description": "Invalid credentials. Please retry your request with correct credentials", "debug": "" }</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h3>Post Details (View Post Comments)</h3>
<table>
<tbody>
<tr>
<td colspan="2" width="1402">
<p><strong>GET</strong> <a href="https://baas.kinvey.com/appdata/app_id/posts">https://baas.kinvey.com/appdata/<strong>app_id</strong>/posts/<strong>post_id</strong></a></p>
</td>
</tr>
<tr>
<td width="261">
<p>Request headers</p>
</td>
<td width="1141">
<p>Authorization: Kinvey authtoken</p>
</td>
</tr>
<tr>
<td width="261">
<p>Response</p>
<p>200 OK</p>
</td>
<td width="1141">
<p>[</p>
<p>&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "_id": "599307d36af42b495f87bad2",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "author": "Kiril",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "description": "My GitHub profile",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "url": "https://github.com/k1r1L",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "title": "GitHub",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "imageUrl": "https://pbs.twimg.com/profile_images/616309728688238592/pBeeJQDQ.png",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "_acl": {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "creator": "kid_B1zfi_e_Z"</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "_kmd": {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "lmt": "2017-08-15T14:40:19.182Z",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "ect": "2017-08-15T14:40:19.182Z"</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp;&nbsp;&nbsp; }</p>
<p>]</p>
</td>
</tr>
<tr>
<td width="261">
<p>Error response</p>
<p>401 Unauthorized</p>
</td>
<td width="1141">
<p>{ "error": "InvalidCredentials", "description": "Invalid credentials. Please retry your request with correct credentials", "debug": "" }</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p><strong>Note: Keep in mind that the quotes used in the query must be exactly double quotes(").</strong></p>
<table>
<tbody>
<tr>
<td colspan="2" width="1402">
<p><strong>GET</strong> <a href="https://baas.kinvey.com/appdata/app_id/posts">https://baas.kinvey.com/appdata/<strong>app_id</strong>/comments?query={"postId":"<strong>post_id</strong>"}</a>&amp;sort={"_kmd.ect": -1}</p>
</td>
</tr>
<tr>
<td width="261">
<p>Request headers</p>
</td>
<td width="1141">
<p>Authorization: Kinvey authtoken</p>
</td>
</tr>
<tr>
<td width="261">
<p>Response</p>
<p>200 OK</p>
</td>
<td width="1141">
<p>[</p>
<p>&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "_id": "599309bdbce993cf532b9643",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "postId": "599307d36af42b495f87bad2",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "author": "Nakov",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "content": "Very cool profile",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "_acl": {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "creator": "kid_B1zfi_e_Z"</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "_kmd": {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "lmt": "2017-08-15T15:50:59.486Z",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "ect": "2017-08-15T14:48:29.551Z"</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "_id": "59930a34133f6d253dfe31c9",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "postId": "599307d36af42b495f87bad2",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "content": "Nice!",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "author": "Viktor",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "_acl": {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "creator": "kid_B1zfi_e_Z"</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "_kmd": {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "lmt": "2017-08-15T14:52:46.189Z",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "ect": "2017-08-15T14:50:28.536Z"</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp;&nbsp;&nbsp; },..</p>
<p>]</p>
</td>
</tr>
<tr>
<td width="261">
<p>Error response</p>
<p>401 Unauthorized</p>
</td>
<td width="1141">
<p>{ "error": "InvalidCredentials", "description": "Invalid credentials. Please retry your request with correct credentials", "debug": "" }</p>
</td>
</tr>
</tbody>
</table>
<h3>Create Comment</h3>
<table>
<tbody>
<tr>
<td colspan="2" width="1402">
<p><strong>POST</strong> <a href="https://baas.kinvey.com/appdata/app_id/comments">https://baas.kinvey.com/appdata/<strong>app_id</strong>/comments</a></p>
</td>
</tr>
<tr>
<td width="261">
<p>Request headers</p>
</td>
<td width="1141">
<p>Authorization: Kinvey authtoken</p>
<p>Content-Type: application/json</p>
</td>
</tr>
<tr>
<td width="261">
<p>Request body</p>
</td>
<td width="1141">
<p>{</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp; "postId": "5993178dbce993cf532bbe29",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp; "content": "Very nice post",</p>
<p>&nbsp;&nbsp;&nbsp; &nbsp;"author": "Kiril"</p>
<p>}</p>
</td>
</tr>
<tr>
<td width="261">
<p>Response</p>
<p>201 Created</p>
</td>
<td width="1141">
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; "postId": "5993178dbce993cf532bbe29",</p>
<p>&nbsp;&nbsp;&nbsp; "content": "Very nice post",</p>
<p>&nbsp;&nbsp;&nbsp; "author": "Kiril",</p>
<p>&nbsp;&nbsp;&nbsp; "_acl": {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "creator": "59930c78a743e20c7d3fca77"</p>
<p>&nbsp;&nbsp;&nbsp; },...</p>
<p>}</p>
</td>
</tr>
<tr>
<td width="261">
<p>Error response</p>
<p>401 Unauthorized</p>
</td>
<td width="1141">
<p>{ "error": "InvalidCredentials", "description": "Invalid credentials. Please retry your request with correct credentials", "debug": "" }</p>
</td>
</tr>
</tbody>
</table>
<h3>Delete Comment</h3>
<table>
<tbody>
<tr>
<td colspan="2" width="1402">
<p><strong>DELETE</strong> <a href="https://baas.kinvey.com/appdata/app_id/comments/comment_id">https://baas.kinvey.com/appdata/<strong>app_id</strong>/comments/<strong>comment_id</strong></a></p>
</td>
</tr>
<tr>
<td width="261">
<p>Request headers</p>
</td>
<td width="1141">
<p>Authorization: Kinvey authtoken</p>
</td>
</tr>
<tr>
<td width="261">
<p>Response</p>
<p>200 OK</p>
</td>
<td width="1141">
<p>{</p>
<p>&nbsp; "count": 1</p>
<p>}</p>
</td>
</tr>
<tr>
<td width="261">
<p>Error response</p>
<p>404 Not Found</p>
</td>
<td width="1141">
<p>{ "error": "EntityNotFound", "description": "This entity not found in the collection", "debug": "" }</p>
</td>
</tr>
<tr>
<td width="261">
<p>Error response</p>
<p>401 Unauthorized</p>
</td>
<td width="1141">
<p>{ "error": "InvalidCredentials", "description": "Invalid credentials. Please retry your request with correct credentials", "debug": "" }</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 3.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; SeentIt&ndash;HTML and CSS</h2>
<p>You аre given the Web design of the Messages application as <strong>HTML</strong> + <strong>CSS</strong> files.</p>
<ul>
<li>Initially all views and forms are shown by the HTML. Your application may <strong>hide</strong> by CSS (display: none) or <strong>delete</strong> from the DOM all unneeded elements or just display the views it needs to display.</li>
<li>You may render the views / forms / components with <strong>jQuery</strong> or <strong>Mustache</strong> <strong>Handlebars</strong>.</li>
</ul>
<p><strong>Important</strong>: don&rsquo;t change the elements&rsquo; <strong>class name</strong> and <strong>id</strong>. Don&rsquo;t rename form fields / link names / ids. You are <strong>allowed</strong> to add <strong>data attributes</strong> to any elements. You may modify <strong>href</strong><strong> attributes</strong> of links and add <strong>action/method attributes</strong> to forms, to allow the use of a routing library.</p>
<h2>Problem 4.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; SeenIt Client-Side Web Application</h2>
<p><strong>Design</strong> and <strong>implement</strong> a client-side front-end app (SPA) for managing <strong>posts</strong> and <strong>comments</strong>. Implement the functionality described below.</p>
<h3>Notifications</h3>
<p>The application should notify the users about the result of their actions.</p>
<ul>
<li>In case of successful action an <strong>informational (green) notification message</strong> should be shown, which disappears automatically after 3 seconds or manually when the user clicks it.</li>
<li>In case of <strong>error</strong>, an <strong>error notification message</strong> (red) should be shown which disappears on user click.</li>
<li>During the AJAX calls a <strong>loading notification message (blue)</strong> should be shown. It should disappear automatically as soon as the AJAX call is completed.</li>
</ul>
<p>&nbsp;</p>
<h3>Navigation System (5 pts)</h3>
<p>Implement a <strong>navigation system</strong> for the app: navigation links should correctly change the current screen (view).</p>
<ul>
<li>Clicking on the links in the <strong>sidebar</strong> or the links on each <strong>individual</strong> post should display the view behind the link (views are sections in the HTML code).</li>
<li>Your application may <strong>hide</strong> by CSS (display: none) or <strong>delete</strong> from the DOM all unneeded elements or just display the views it needs to display.</li>
<li>The given &bdquo;<strong>Navigation</strong>&ldquo; sidebar should be visible <strong>only</strong> for logged in users. Anonymous users can <strong>only</strong> view the <strong>sign in/register</strong></li>
</ul>
<h3>Register User (10 pts)</h3>
<p>By given <strong>username</strong>, <strong>password</strong><strong> and repeat password</strong> the app should register a new user in the system.</p>
<ul>
<li>After a <strong>successful registration</strong>, a notification message &ldquo;User registration successful.&rdquo; should be displayed and the <strong>catalog</strong> with all <strong>posts</strong> should be shown.</li>
<li>You <strong>need</strong> to validate the <strong>input</strong>. A username <strong>should</strong> be at <strong>least</strong> 3 characters <strong>long</strong> and should contain only english alphabet <strong>letters</strong>. A user&lsquo;s password should be at <strong>least</strong> 6 characters <strong>long</strong> and should contain only english alphabet <strong>letters</strong> and <strong>digits</strong>. Both passwords <strong>should</strong></li>
<li>In case of <strong>error</strong> (eg. invalid username/password), an appropriate error <strong>message</strong> should be displayed and the user should be able to <strong>try</strong> to register again.</li>
<li>Keep the user session data in the browser&rsquo;s <strong>session storage</strong>.</li>
<li>Clear <strong>all</strong> input fields after <strong>successful</strong></li>
</ul>
<h3>Login User (5 pts)</h3>
<p>By given <strong>username</strong> and <strong>password</strong> the app should be able to login an existing user.</p>
<ul>
<li>After a <strong>successful login</strong>, a notification message &ldquo;Login successful.&rdquo; should be displayed and the user home screen should be displayed.</li>
<li>In case of <strong>error</strong>, an appropriate error message should be displayed and the user should be able to fill the login form again.</li>
<li><strong>Form validation</strong> should be the <strong>same</strong> as register.</li>
<li>Keep the user session data in the browser&rsquo;s <strong>session storage</strong>.</li>
<li>Clear <strong>all</strong> input fields after <strong>successful</strong></li>
</ul>
<p>&nbsp;</p>
<h3>Logout (5 pts)</h3>
<p>Successfully logged in user should be able to <strong>logout</strong> from the app.</p>
<ul>
<li>After a <strong>successful</strong> logout, a <strong>notification</strong> message &ldquo;Logout successful.&rdquo; should be displayed.</li>
<li>After successful logout, the <strong>Sign </strong><strong>In screen</strong> should be shown.</li>
<li>The <strong>&ldquo;logout&rdquo; REST service</strong> at the back-end should be obligatory called at logout.</li>
<li>All local information in the browser (<strong>user session data</strong>) about the current user should be deleted.</li>
</ul>
<h3>Catalog Screen (20 pts)</h3>
<p>Successfully logged users should be welcomed by the <strong>catalog</strong> screen which can be accessed <strong>after</strong> clicking the <strong>[Catalog]</strong> link in the <strong>sidebar</strong>. The catalog contains <strong>all</strong> posts on the site.</p>
<ul>
<li>The <strong>posts</strong> should be listed in the <strong>format</strong> as shown in the Web design (see the screenshot below).</li>
<li>Each <strong>post</strong> has <strong>title</strong>, <strong>url</strong>, <strong>imageUrl</strong> (optional), <strong>description</strong> (optional), <strong>rank</strong> (order number) and information about <strong>when</strong> it was <strong>created</strong>. For the <strong>time created</strong> information you will use a helper function given <strong>below</strong>. It requires a <strong>parameter</strong> which is the entity creation date of the post (or <strong>ect </strong>property of the post object).</li>
<li>When the <strong>comments</strong> link is clicked, your app should <strong>redirect</strong> to the details <strong>section</strong> of the post with comments.</li>
<li>Post <strong>authors</strong> can edit/delete their <strong>own</strong></li>
<li>In case of <strong>error</strong> (e.g. Internet connection lost), an error message should be displayed.</li>
<li>In case of <strong>no posts</strong>, display &lsquo;No posts in database&rsquo;.</li>
<li>Format the entity creation <strong>date</strong> of a <strong>post</strong> as shown in the screenshot above. You may <strong>use</strong> the following helper function:</li>
</ul>
<table>
<tbody>
<tr>
<td width="1301">
<p><strong>function </strong><em>calcTime</em>(dateIsoFormat) {<br /> &nbsp;&nbsp;&nbsp; <strong>let </strong>diff = <strong>new </strong>Date - (<strong>new </strong>Date(dateIsoFormat));<br /> &nbsp;&nbsp;&nbsp; diff = <strong><em>Math</em></strong>.floor(diff / 60000);<br /> &nbsp;&nbsp;&nbsp; <strong>if </strong>(diff &lt; 1) <strong>return </strong><strong>'less than a minute'</strong>;<br /> &nbsp;&nbsp;&nbsp; <strong>if </strong>(diff &lt; 60) <strong>return </strong>diff + <strong>' minute' </strong>+ <em>pluralize</em>(diff);<br /> &nbsp;&nbsp;&nbsp; diff = <strong><em>Math</em></strong>.floor(diff / 60);<br /> &nbsp;&nbsp;&nbsp; <strong>if </strong>(diff &lt; 24) <strong>return </strong>diff + <strong>' hour' </strong>+ <em>pluralize</em>(diff);<br /> &nbsp;&nbsp;&nbsp; diff = <strong><em>Math</em></strong>.floor(diff / 24);<br /> &nbsp;&nbsp;&nbsp; <strong>if </strong>(diff &lt; 30) <strong>return </strong>diff + <strong>' day' </strong>+ <em>pluralize</em>(diff);<br /> &nbsp;&nbsp;&nbsp; diff = <strong><em>Math</em></strong>.floor(diff / 30);<br /> &nbsp;&nbsp;&nbsp; <strong>if </strong>(diff &lt; 12) <strong>return </strong>diff + <strong>' month' </strong>+ <em>pluralize</em>(diff);<br /> &nbsp;&nbsp;&nbsp; diff = <strong><em>Math</em></strong>.floor(diff / 12);<br /> &nbsp;&nbsp;&nbsp; <strong>return </strong>diff + <strong>' year' </strong>+ <em>pluralize</em>(diff);<br /> &nbsp;&nbsp;&nbsp; <strong>function </strong><em>pluralize</em>(value) {<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>if </strong>(value !== 1) <strong>return </strong><strong>'s'</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>else return </strong><strong>''</strong>;<br /> &nbsp;&nbsp;&nbsp; }<br /> }</p>
</td>
</tr>
</tbody>
</table>
<ul>
<li>Ensure you handle properly all HTML <strong>special characters</strong>, e.g. the message text could hold "<em>Hi, &lt;peter&gt;</em>".</li>
</ul>
<h3>Create Post Screen (10 pts)</h3>
<p>Logged in users can <strong>create</strong> posts. Clicking the <strong>[Submit Link]</strong> link should open a form. A post has <strong>author</strong>, <strong>url</strong>, <strong>title</strong>, <strong>imageUrl</strong> (optional), <strong>description</strong> (optional).</p>
<ul>
<li>After a <strong>successful</strong> post creation, a notification message &ldquo;Post created.&rdquo; should be displayed and the <strong>catalog</strong> should be shown.</li>
<li><strong>Link url</strong> and <strong>title</strong> are <strong>not</strong> optional, also link url should always start with &ldquo;<strong>http</strong>&rdquo;. In case of <strong>empty/incorrect</strong> input fields an appropriate <strong>error</strong> message should be <strong>displayed</strong> and the user should be able to fill the <strong>form</strong></li>
<li>Clear <strong>all</strong> input fields after <strong>successful</strong> creation.</li>
<li>Ensure you handle properly all HTML <strong>special characters</strong>, e.g. the message text could hold "<em>Hi, &lt;peter&gt;</em>".</li>
</ul>
<h3>Edit Post Screen (10 pts)</h3>
<p>Authors <strong>should</strong> be able to <strong>edit</strong> their <strong>own</strong> posts. Clicking the [<strong>Edit</strong>] link on each post should open an edit <strong>form</strong>. Inside the edit form all input fields should be <strong>filled</strong> with the <strong>current</strong> data of each post.</p>
<ul>
<li>After a <strong>successful</strong> post update, a notification message &ldquo;Post {postTitle} updated.&rdquo; should be displayed and the <strong>catalog</strong> should be shown.</li>
<li><strong>Link url</strong> and <strong>title</strong> are <strong>not</strong> optional, also link url should always start with &ldquo;<strong>http</strong>&rdquo;. In case of <strong>empty/incorrect</strong> input fields an appropriate <strong>error</strong> message should be <strong>displayed</strong> and the user should be able to fill the <strong>form</strong></li>
<li>Ensure you handle properly all HTML <strong>special characters</strong>, e.g. the message text could hold "<em>Hi, &lt;peter&gt;</em>".</li>
</ul>
<h3>Delete Post (5 pts)</h3>
<p>Authors <strong>should</strong> be able to <strong>delete</strong> their <strong>own</strong> posts by clicking the [<strong>Delete</strong>] button.</p>
<ul>
<li>After <strong>successful</strong> post delete a notification message &ldquo;Post deleted.&rdquo; should be displayed and the <strong>catalog</strong> should be <strong>shown</strong>.</li>
<li>In case of <strong>error</strong> (e.g. Internet connection lost / unauthorized request / missing message), an error message should be displayed.</li>
<li>Deleting works immediately, with <strong>no confirmation</strong>.</li>
</ul>
<h3>My Posts (5 pts)</h3>
<p>Each <strong>user </strong>should be able to view his own posts by clicking [<strong>My Posts</strong>].</p>
<ul>
<li>The <strong>posts</strong> should be listed like in the <strong>catalog</strong></li>
<li>In case of <strong>error</strong> (e.g. Internet connection lost), an error message should be displayed.</li>
<li>In case of <strong>no posts</strong>, display &lsquo;No posts in database&rsquo;.</li>
</ul>
<h3>Post Details (15 pts)</h3>
<p>Each <strong>post</strong> has a details view. By clicking the [<strong>Comments</strong>] link <strong>partial</strong> information about each post should be listed (post <strong>image</strong>, post <strong>title</strong>, post <strong>description</strong>), and most importantly each comment <strong>connected</strong> to the post.</p>
<ul>
<li>In case of <strong>error</strong> (e.g. Internet connection lost), an error message should be displayed.</li>
<li>If there is <strong>no</strong> description add &ldquo;No description&rdquo; in it&rsquo;s place.</li>
<li>If there are <strong>no</strong> comments under the post display &ldquo;No comments yet.&rdquo;</li>
<li>Each comment author has the <strong>ability</strong> to <strong>delete</strong> their own comment.</li>
<li>Ensure you handle properly all HTML <strong>special characters</strong>, e.g. the message text could hold "<em>Hi, &lt;peter&gt;</em>".</li>
</ul>
<h3>Create Comment (5 pts)</h3>
<p>Every <strong>logged</strong> in user has the ability to <strong>create</strong> a comment under a post by clicking [<strong>Add Comment</strong>].</p>
<ul>
<li>After a <strong>successful</strong> comment creation, a notification message &ldquo;Comment created.&rdquo; should be displayed and the post details should be shown <strong>again</strong> with the newly added comment.</li>
<li>Clear the <strong>input</strong> field after <strong>successful</strong> creation.</li>
<li>Ensure you handle properly all HTML <strong>special characters</strong>, e.g. the message text could hold "<em>Hi, &lt;peter&gt;</em>".</li>
</ul>
<h3>Delete Comment (5 pts)</h3>
<p>Every <strong>author </strong>has the ability to delete his own comment under a post by clicking [<strong>Delete</strong>]</p>
<ul>
<li>After a <strong>successful</strong> comment delete, a notification message &ldquo;Comment deleted.&rdquo; should be displayed and the post details should be shown <strong>again</strong> without the deleted comment.</li>
<li>Ensure you handle properly all HTML <strong>special characters</strong>, e.g. the message text could hold "<em>Hi, &lt;peter&gt;</em>".</li>
</ul>
<h2>Problem 5.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Subtmitting Your Solution</h2>
<p>Place in a ZIP file your project folder. Exclude the node_modules folder. Upload the archive to the Judge.</p>


<h1>JS Apps Exam &ndash; Chirper Single Page Application</h1>
<p>You are assigned to implement a <strong>Web application</strong> (SPA) using HTML5, JavaScript, AJAX, REST and JSON with cloud-based backend (Kinvey). The app keeps <strong>users and chirps (tweets)</strong>. Users can <strong>register</strong>, <strong>login,</strong> <strong>logout</strong>, view <strong>feed</strong> page (all chirps from followers sorted by time in descending), <strong>create</strong> a chirp, <strong>delete</strong> a chirp, view <strong>own</strong> chirps, <strong>discover</strong> new people, get <strong>all chirps</strong> by specific user (sorted by time in descending), <strong>follow</strong> or <strong>unfollow</strong> a user.</p>
<p>Using libraries like <strong>jQuery</strong>, <strong>Handlebars</strong> and <strong>Sammy</strong> is allowed but is not obligatory.</p>
<h2>Problem 1.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Create a Kinvey REST Service</h2>
<p>Register at <strong>Kinvey.com</strong> and create an application to keep your data in the cloud.</p>
<p>Each user has a <strong>username</strong>, <strong>password</strong> and <strong>subscriptions (array of usernames)</strong>.</p>
<p>In the <strong>Users</strong> collection, import the provided JSON file with sample users to get started with template data. In the <strong>Kinvey Console</strong>, select <strong>Users</strong> from the navigation of the left, click <strong>Settings</strong> in the upper right then scroll down to the <strong>Import</strong> section:</p>
<p>Create a collection <strong>chirps</strong>. Each chirp has a <strong>text</strong> (string with max length 150 and cannot be empty) and an <strong>author</strong> (username of the creator).</p>
<p>You are also given<strong> one</strong> more json file to <strong>import</strong> your <strong>chirps</strong>.</p>
<h2>Problem 2.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Test the Kinvey REST Services</h2>
<p>Using <strong>Postman</strong> or other HTTP client tool (you can use Kinvey&rsquo;s built-in <strong>API Console</strong>), test the REST service endpoints:</p>
<h3>User Registration (Sign Up)</h3>
<table>
<tbody>
<tr>
<td colspan="2" width="1402">
<p><strong>POST</strong> https://baas.kinvey.com/user/<strong><em>app_key</em></strong>/</p>
</td>
</tr>
<tr>
<td width="261">
<p>Request headers</p>
</td>
<td width="1141">
<p>Authorization: Basic base64(app_id:app_secret)</p>
<p>Content-Type: application/json</p>
</td>
</tr>
<tr>
<td width="261">
<p>Request body</p>
</td>
<td width="1141">
<p>{</p>
<p>&nbsp; "username": "testuser",</p>
<p>&nbsp; "password": "testuserpass890",</p>
<p>&nbsp; "subscriptions": []</p>
<p>}</p>
</td>
</tr>
<tr>
<td width="261">
<p>Response</p>
<p>201 Created</p>
</td>
<td width="1141">
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; "_id": "<strong>59affdae3044bb86044a79bd</strong>",</p>
<p>&nbsp;&nbsp;&nbsp; "username": "<strong>testuser</strong>",</p>
<p>&nbsp; &nbsp;&nbsp;"password": "<strong>testuserpass890</strong>",</p>
<p>&nbsp;&nbsp;&nbsp; "subscriptions": <strong>[]</strong></p>
<p>}</p>
</td>
</tr>
<tr>
<td width="261">
<p>Error response</p>
<p>409 Conflict</p>
</td>
<td width="1141">
<p>{ "error": "UserAlreadyExists", "description": "This username is already taken. Please retry your request with a different username",&nbsp; "debug": "" }</p>
</td>
</tr>
<tr>
<td width="261">
<p>Error response</p>
<p>401 Unauthorized</p>
</td>
<td width="1141">
<p>{ "error": "InvalidCredentials", "description": "Invalid credentials. Please retry your request with correct credentials", "debug": "" }</p>
</td>
</tr>
</tbody>
</table>
<p>The request needs &ldquo;<strong>Basic</strong>&rdquo; authentication. Use the Kinvey <strong>App Key</strong> and Kinvey <strong>App Secret</strong> as credentials.</p>
<p>&nbsp;</p>
<h3>User Login</h3>
<table>
<tbody>
<tr>
<td colspan="2" width="1402">
<p><strong>POST</strong> https://baas.kinvey.com/user/<strong><em>app_key</em></strong>/login</p>
</td>
</tr>
<tr>
<td width="261">
<p>Request headers</p>
</td>
<td width="1141">
<p>Authorization: Basic base64(app_id:app_secret)</p>
<p>Content-Type: application/json</p>
</td>
</tr>
<tr>
<td width="261">
<p>Request body</p>
</td>
<td width="1141">
<p>{</p>
<p>&nbsp; "username": "testuser",</p>
<p>&nbsp; "password": "testuserpass890"</p>
<p>}</p>
</td>
</tr>
<tr>
<td width="261">
<p>Response</p>
<p>200 OK</p>
</td>
<td width="1141">
<p>{</p>
<p>&nbsp; "_id": "59930c78a743e20c7d3fca77",</p>
<p>&nbsp; "username": "testuser",</p>
<p>&nbsp; "subscriptions": []</p>
<p>&nbsp; "_kmd": {</p>
<p>&nbsp;&nbsp;&nbsp; "<strong>authtoken</strong>": "<strong>8e6471bc-3712-4cfb-b92e-50e62a0c80&hellip;.Duj5fHdM /7XHIe6KdY=</strong>"</p>
<p>&nbsp;&nbsp;&nbsp; &hellip;</p>
<p>&nbsp; },</p>
<p>&nbsp; &hellip;</p>
<p>}</p>
</td>
</tr>
<tr>
<td width="261">
<p>Error response</p>
<p>401 Unauthorized</p>
</td>
<td width="1141">
<p>{ "error": "InvalidCredentials", "description": "Invalid credentials. Please retry your request with correct credentials", "debug": "" }</p>
</td>
</tr>
</tbody>
</table>
<p>Successful login returns an &ldquo;<strong>authtoken</strong>&rdquo; which is later used to authenticate the CRUD operations. <strong>You may consider saving other useful information for later use.</strong></p>
<h3>User Logout</h3>
<table>
<tbody>
<tr>
<td colspan="2" width="1402">
<p><strong>POST</strong> https://baas.kinvey.com/user/<strong><em>app_key</em></strong>/_logout</p>
</td>
</tr>
<tr>
<td width="261">
<p>Request headers</p>
</td>
<td width="1141">
<p>Authorization: Kinvey <strong>authtoken</strong></p>
</td>
</tr>
<tr>
<td width="261">
<p>Response</p>
<p>204 No Content</p>
</td>
<td width="1141">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="261">
<p>Error response</p>
<p>401 Unauthorized</p>
</td>
<td width="1141">
<p>{ "error": "InvalidCredentials", "description": "Invalid credentials. Please retry your request with correct credentials", "debug": "" }</p>
</td>
</tr>
</tbody>
</table>
<p>To logout, you need to provide the &ldquo;<strong>authtoken</strong>&rdquo; given by login / register as &ldquo;<strong>Kinvey</strong>&rdquo; authorization header.</p>
<h3>List all Chirps from subscriptions (Feed &ndash; sorted by post time, descending)</h3>
<table>
<tbody>
<tr>
<td colspan="2" width="1402">
<p><strong>GET</strong> https://baas.kinvey.com/appdata/<strong><em>app_key</em></strong>/chirps?query={"author":{"$in": <strong>[<em>subs</em>]</strong>}}&amp;sort={"_kmd.ect": 1}</p>
</td>
</tr>
<tr>
<td width="261">
<p>Request headers</p>
</td>
<td width="1141">
<p>Authorization: Kinvey authtoken</p>
</td>
</tr>
<tr>
<td width="261">
<p>Response</p>
<p>200 OK</p>
</td>
<td width="1141">
<p>[</p>
<p>&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "_id": "59ae7752e884417c04e803a4",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "text": "yohooo",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "_acl": {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "creator": "59ae425c14ee505004862409"</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "author": "vako",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "_kmd": {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "lmt": "2017-09-05T11:38:02.944Z",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "ect": "2017-09-05T10:07:14.314Z"</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp;&nbsp;&nbsp; },&hellip;</p>
</td>
</tr>
<tr>
<td width="261">
<p>Error response</p>
<p>401 Unauthorized</p>
</td>
<td width="1141">
<p>{ "error": "InvalidCredentials", "description": "Invalid credentials. Please retry your request with correct credentials", "debug": "" }</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>Where :subs is an array of subscriptions (by username).</p>
<h3>Create Chirp</h3>
<table>
<tbody>
<tr>
<td colspan="2" width="1402">
<p><strong>POST</strong> https://baas.kinvey.com/appdata/<strong><em>app_key</em></strong>/chirps</p>
</td>
</tr>
<tr>
<td width="261">
<p>Request headers</p>
</td>
<td width="1141">
<p>Authorization: Kinvey authtoken</p>
<p>Content-Type: application/json</p>
</td>
</tr>
<tr>
<td width="261">
<p>Request body</p>
</td>
<td width="1141">
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; "text": "<strong>MyTestChirp</strong>",</p>
<p>&nbsp;&nbsp;&nbsp; "author": "<strong>testuser</strong>"</p>
<p>}</p>
</td>
</tr>
<tr>
<td width="261">
<p>Response</p>
<p>201 Created</p>
</td>
<td width="1141">
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; "_id": "59931398996ab5127d2a84d1",</p>
<p>&nbsp;&nbsp;&nbsp; "author": "Kiril",</p>
<p>&nbsp;&nbsp;&nbsp; "title": "Test Post",</p>
<p>&nbsp;&nbsp;&nbsp; "description": "Test Post Description",</p>
<p>&nbsp;&nbsp;&nbsp; "url": "https://en.wikipedia.org/wiki/Santorini",&hellip;</p>
<p>}</p>
</td>
</tr>
<tr>
<td width="261">
<p>Error response</p>
<p>401 Unauthorized</p>
</td>
<td width="1141">
<p>{ "error": "InvalidCredentials", "description": "Invalid credentials. Please retry your request with correct credentials", "debug": "" }</p>
</td>
</tr>
</tbody>
</table>
<h3>Delete Chirp</h3>
<table>
<tbody>
<tr>
<td colspan="2" width="1402">
<p><strong>DELETE</strong> https://baas.kinvey.com/appdata/<strong><em>app_key</em></strong>/chirps/<strong><em>chirp_id </em></strong></p>
</td>
</tr>
<tr>
<td width="261">
<p>Request headers</p>
</td>
<td width="1141">
<p>Authorization: Kinvey authtoken</p>
</td>
</tr>
<tr>
<td width="261">
<p>Response</p>
<p>200 OK</p>
</td>
<td width="1141">
<p>{</p>
<p>&nbsp; "count": 1</p>
<p>}</p>
</td>
</tr>
<tr>
<td width="261">
<p>Error response</p>
<p>404 Not Found</p>
</td>
<td width="1141">
<p>{ "error": "EntityNotFound", "description": "This entity not found in the collection", "debug": "" }</p>
</td>
</tr>
<tr>
<td width="261">
<p>Error response</p>
<p>401 Unauthorized</p>
</td>
<td width="1141">
<p>{ "error": "InvalidCredentials", "description": "Invalid credentials. Please retry your request with correct credentials", "debug": "" }</p>
</td>
</tr>
</tbody>
</table>
<h3>User Chirps (View all chirps by user, sorted by post time, descending)</h3>
<table>
<tbody>
<tr>
<td colspan="2" width="1402">
<p><strong>GET </strong>https://baas.kinvey.com/appdata/<strong><em>app_key</em></strong>/chirps?query={"author":"<strong><em>username</em></strong>"}&amp;sort={"_kmd.ect": 1}</p>
</td>
</tr>
<tr>
<td width="261">
<p>Request headers</p>
</td>
<td width="1141">
<p>Authorization: Kinvey authtoken</p>
</td>
</tr>
<tr>
<td width="261">
<p>Response</p>
<p>200 OK</p>
</td>
<td width="1141">
<p>[</p>
<p>&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "_id": "59b004cfdfab74540457702a",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "text": "#testuserchirp",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "author": "testuser",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "_acl": {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "creator": "59affdae3044bb86044a79bd"</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "_kmd": {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "lmt": "2017-09-06T14:23:11.069Z",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "ect": "2017-09-06T14:23:11.069Z"</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp;&nbsp;&nbsp; },..</p>
</td>
</tr>
<tr>
<td width="261">
<p>Error response</p>
<p>401 Unauthorized</p>
</td>
<td width="1141">
<p>{ "error": "InvalidCredentials", "description": "Invalid credentials. Please retry your request with correct credentials", "debug": "" }</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>The <strong>next</strong> 3 queries are needed to <strong>display</strong> profile <strong>stats.</strong></p>
<h3>Count Chirps</h3>
<table>
<tbody>
<tr>
<td colspan="2" width="1402">
<p><strong>GET</strong> https://baas.kinvey.com/appdata/<strong><em>app_key</em></strong>/chirps?query={"author":"<strong>username</strong>"}</p>
</td>
</tr>
<tr>
<td width="261">
<p>Request headers</p>
</td>
<td width="1141">
<p>Authorization: Kinvey authtoken</p>
</td>
</tr>
<tr>
<td width="261">
<p>Response</p>
<p>200 OK</p>
</td>
<td width="1141">
<p>[</p>
<p>&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "_id": "59b004cfdfab74540457702a",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "text": "#testuserchirp",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "author": "testuser",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "_acl": {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "creator": "59affdae3044bb86044a79bd"</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "_kmd": {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "lmt": "2017-09-06T14:23:11.069Z",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "ect": "2017-09-06T14:23:11.069Z"</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp;&nbsp;&nbsp; },..</p>
</td>
</tr>
<tr>
<td width="261">
<p>Error response</p>
<p>401 Unauthorized</p>
</td>
<td width="1141">
<p>{ "error": "InvalidCredentials", "description": "Invalid credentials. Please retry your request with correct credentials", "debug": "" }</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>This query will return <strong>all</strong> the chirps by <strong>given</strong> user. <strong>Count</strong> them.</p>
<h3>Count Following (All users that the currently logged is subscribed to)</h3>
<table>
<tbody>
<tr>
<td colspan="2" width="1402">
<p><strong>GET</strong> https://baas.kinvey.com/user/<strong><em>app_key</em></strong>/?query={"username":"<strong>username</strong>"}</p>
</td>
</tr>
<tr>
<td width="261">
<p>Request headers</p>
</td>
<td width="1141">
<p>Authorization: Kinvey authtoken</p>
</td>
</tr>
<tr>
<td width="261">
<p>Response</p>
<p>200 OK</p>
</td>
<td width="1141">
<p>[</p>
<p>&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "_id": "59afe6ad68c53f4a045534df",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "subscriptions": [</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "vako"</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ],</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "username": "Kiril98",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "_acl": {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "creator": "59afe6ad68c53f4a045534df"</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "_kmd": {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "lmt": "2017-09-06T12:37:47.242Z",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "ect": "2017-09-06T12:14:37.861Z"</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp;&nbsp;&nbsp; }</p>
<p>]</p>
</td>
</tr>
<tr>
<td width="261">
<p>Error response</p>
<p>401 Unauthorized</p>
</td>
<td width="1141">
<p>{ "error": "InvalidCredentials", "description": "Invalid credentials. Please retry your request with correct credentials", "debug": "" }</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>This query will return the <strong>needed</strong> user. The <strong>count</strong> of the people that the user is <strong>following</strong> is the <strong>length</strong> of the subscriptions array.</p>
<h3>Count Followers (All users that are subscribed to the currently logged)</h3>
<table>
<tbody>
<tr>
<td colspan="2" width="1402">
<p><strong>GET</strong> https://baas.kinvey.com/user/<strong><em>app_key</em></strong>/?query={"subscriptions":"<strong><em>username</em></strong>"}</p>
</td>
</tr>
<tr>
<td width="261">
<p>Request headers</p>
</td>
<td width="1141">
<p>Authorization: Kinvey authtoken</p>
</td>
</tr>
<tr>
<td width="261">
<p>Response</p>
<p>200 OK</p>
</td>
<td width="1141">
<p>[</p>
<p>&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "_id": "59afe70614ee5050048cecfb",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "subscriptions": [</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Kiril98",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "SoftUni"</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ],</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "username": "kirilvk1",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "_acl": {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "creator": "59afe70614ee5050048cecfb"</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "_kmd": {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "lmt": "2017-09-06T12:16:19.636Z",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "ect": "2017-09-06T12:16:06.222Z"</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "_id": "59affdae3044bb86044a79bd",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "subscriptions": [</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Kiril98",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Tacito"</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ],&hellip;</p>
<p>]</p>
</td>
</tr>
<tr>
<td width="261">
<p>Error response</p>
<p>401 Unauthorized</p>
</td>
<td width="1141">
<p>{ "error": "InvalidCredentials", "description": "Invalid credentials. Please retry your request with correct credentials", "debug": "" }</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>The following query will return all <strong>users</strong> that are <strong>subscribed</strong> to given username. You need the length of this array.</p>
<h3>Discover Page</h3>
<table>
<tbody>
<tr>
<td colspan="2" width="1402">
<p><strong>GET</strong> https://baas.kinvey.com/user/<strong><em>app_key</em></strong>/</p>
</td>
</tr>
<tr>
<td width="261">
<p>Request headers</p>
</td>
<td width="1141">
<p>Authorization: Kinvey authtoken</p>
</td>
</tr>
<tr>
<td width="261">
<p>Response</p>
<p>200 OK</p>
</td>
<td width="1141">
<p>[</p>
<p>&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "_id": "59ae425c14ee505004862409",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "subscriptions": [</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Tacito",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "SoftUni"</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ],</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "username": "vako",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "_acl": {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "creator": "59ae425c14ee505004862409"</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "_kmd": {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "lmt": "2017-09-05T17:14:56.960Z",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "ect": "2017-09-05T06:21:16.793Z"</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "_id": "59ae864f603d08cc6fedf3ab",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "username": "Tacito",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "_acl": {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "creator": "59ae864f603d08cc6fedf3ab"</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "subscriptions": [],</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "_kmd": {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "lmt": "2017-09-05T11:42:53.473Z",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "ect": "2017-09-05T11:11:11.629Z"</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;}</p>
<p>&nbsp;&nbsp;&nbsp; },..</p>
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="261">
<p>Error response</p>
<p>401 Unauthorized</p>
</td>
<td width="1141">
<p>{ "error": "InvalidCredentials", "description": "Invalid credentials. Please retry your request with correct credentials", "debug": "" }</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>This will return all users. In the discover page you should <strong>display</strong> all users <strong>except</strong> the currently logged.</p>
<h3>Follow</h3>
<table>
<tbody>
<tr>
<td colspan="2" width="1402">
<p><strong>PUT</strong> https://baas.kinvey.com/user/<strong><em>app_key</em></strong>/<strong><em>user_id</em></strong></p>
</td>
</tr>
<tr>
<td width="261">
<p>Request headers</p>
</td>
<td width="1141">
<p>Authorization: Kinvey authtoken</p>
<p>Content-Type: application/json</p>
</td>
</tr>
<tr>
<td width="261">
<p>Request body</p>
</td>
<td width="1141">
<p>{</p>
<p>&nbsp;&nbsp; "subscriptions": [</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "testuser",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "vako",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "<strong>Tacito</strong>"</p>
<p>&nbsp;&nbsp;&nbsp; ]</p>
<p>}</p>
</td>
</tr>
<tr>
<td width="261">
<p>Response</p>
<p>200 OK</p>
</td>
<td width="1141">
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; "subscriptions": [</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "testuser",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "vako",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "<strong>Tacito</strong>"</p>
<p>&nbsp;&nbsp;&nbsp; ],</p>
<p>&nbsp;&nbsp;&nbsp; "_id": "59afe6ad68c53f4a045534df",</p>
<p>&nbsp;&nbsp;&nbsp; "username": "Kiril98",&hellip;</p>
</td>
</tr>
<tr>
<td width="261">
<p>Error response</p>
<p>401 Unauthorized</p>
</td>
<td width="1141">
<p>{ "error": "InvalidCredentials", "description": "Invalid credentials. Please retry your request with correct credentials", "debug": "" }</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>The PUT query does <strong>not</strong> need to include the <strong>whole</strong> user object. Submit <strong>only</strong> the modified subscriptions array.</p>
<h3>Unfollow</h3>
<table>
<tbody>
<tr>
<td colspan="2" width="1402">
<p><strong>PUT</strong> https://baas.kinvey.com/user/<strong><em>app_key</em></strong>/<strong><em>user_id</em></strong></p>
</td>
</tr>
<tr>
<td width="261">
<p>Request headers</p>
</td>
<td width="1141">
<p>Authorization: Kinvey authtoken</p>
<p>Content-Type: application/json</p>
</td>
</tr>
<tr>
<td width="261">
<p>Request body</p>
</td>
<td width="1141">
<p>{</p>
<p>&nbsp;&nbsp; "subscriptions": [</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "testuser",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "vako"</p>
<p>&nbsp;&nbsp;&nbsp; ]</p>
<p>}</p>
</td>
</tr>
<tr>
<td width="261">
<p>Response</p>
<p>200 OK</p>
</td>
<td width="1141">
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; "subscriptions": [</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "testuser",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "vako"</p>
<p>&nbsp;&nbsp;&nbsp; ],</p>
<p>&nbsp;&nbsp;&nbsp; "_id": "59afe6ad68c53f4a045534df",</p>
<p>&nbsp;&nbsp;&nbsp; "username": "Kiril98",&hellip;</p>
</td>
</tr>
<tr>
<td width="261">
<p>Error response</p>
<p>401 Unauthorized</p>
</td>
<td width="1141">
<p>{ "error": "InvalidCredentials", "description": "Invalid credentials. Please retry your request with correct credentials", "debug": "" }</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>The <strong>same</strong> query as &ldquo;<strong>Follow</strong>&rdquo;. Only this time we <strong>remove</strong> the wanted username and submit the modified subscriptions array.</p>
<h2>Problem 3.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Chirper&ndash;HTML and CSS</h2>
<p>You аre given the Web design of the <strong>Chirper</strong> application as <strong>HTML</strong> + <strong>CSS</strong> files.</p>
<ul>
<li>Initially all views and forms are shown by the HTML. Your application may <strong>hide</strong> by CSS (display: none) or <strong>delete</strong> from the DOM all unneeded elements or just display the views it needs to display.</li>
<li>You may render the views / forms / components with <strong>jQuery</strong> or <strong>Mustache</strong> <strong>Handlebars</strong>.</li>
</ul>
<p><strong>Important</strong>: don&rsquo;t change the elements&rsquo; <strong>class name</strong> and <strong>id</strong>. Don&rsquo;t rename form fields / link names / ids. You are <strong>allowed</strong> to add <strong>data attributes</strong> to any elements. You may modify <strong>href</strong><strong> attributes</strong> of links and add <strong>action/method attributes</strong> to forms, to allow the use of a routing library.</p>
<h2>Problem 4.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Chirper Client-Side Web Application</h2>
<p><strong>Design</strong> and <strong>implement</strong> a client-side front-end app (SPA) for managing <strong>users</strong> and <strong>chirps</strong><strong> (tweets)</strong>. Implement the functionality described below.</p>
<h3>Notifications</h3>
<p>The application should notify the users about the result of their actions.</p>
<ul>
<li>In case of successful action an <strong>informational (green) notification message</strong> should be shown, which disappears automatically after 3 seconds or manually when the user clicks it.</li>
<li>In case of <strong>error</strong>, an <strong>error notification message</strong> (red) should be shown which disappears on user click.</li>
<li>During the AJAX calls a <strong>loading notification message (blue)</strong> should be shown. It should disappear automatically as soon as the AJAX call is completed.</li>
</ul>
<p>&nbsp;</p>
<h3>Navigation System (5 pts)</h3>
<p>Implement a <strong>navigation system</strong> for the app: navigation links should correctly change the current screen (view).</p>
<ul>
<li>Clicking on the links in the <strong>navbar</strong> or the links on each <strong>individual</strong> post should display the view behind the link (views are sections in the HTML code).</li>
<li>Your application may <strong>hide</strong> by CSS (display: none) or <strong>delete</strong> from the DOM all unneeded elements or just display the views it needs to display.</li>
<li>The given <strong>navbar</strong> should be visible <strong>only</strong> for logged in users. Anonymous users can <strong>only</strong> view the <strong>sign in/register</strong></li>
</ul>
<h3>Register User Screen (10 pts)</h3>
<p>By given <strong>username</strong>, <strong>password</strong><strong> and repeat password</strong> the app should register a new user in the system.</p>
<ul>
<li>After a <strong>successful registration</strong>, a notification message &ldquo;User registration successful.&rdquo; should be displayed and the <strong>feed page</strong> with all <strong>chirps by followers</strong> should be shown.</li>
<li>You <strong>need</strong> to validate the <strong>input</strong>. A username <strong>should</strong> be a string with at <strong>least</strong> 5 characters<strong> long</strong>. Passwords <strong>input</strong> fields shouldn&rsquo;t be <strong>empty</strong>. Both passwords <strong>should</strong></li>
<li>In case of <strong>error</strong> (eg. invalid username/password), an appropriate error <strong>message</strong> should be displayed and the user should be able to <strong>try</strong> to register again.</li>
<li>Keep the user session data in the browser&rsquo;s <strong>session storage</strong>.</li>
<li>That <strong>includes</strong> the subscriptions array. Since local/session storage <strong>only</strong> keeps <strong>strings</strong> the array must be <strong>stringified </strong>or <strong>kept</strong> as a variable and <strong>updated</strong> on every init.</li>
<li>Clear <strong>all</strong> input fields after <strong>successful</strong> register.</li>
</ul>
<h3>Login User Screen (5 pts)</h3>
<p>By given <strong>username</strong> and <strong>password</strong> the app should be able to login an existing user.</p>
<ul>
<li>After a <strong>successful login</strong>, a notification message &ldquo;Login successful.&rdquo; should be displayed and and the <strong>feed page</strong> with all <strong>chirps by followers</strong> should be shown.</li>
<li>In case of <strong>error</strong>, an appropriate error message should be displayed and the user should be able to fill the login form again.</li>
<li><strong>Form validation</strong> should be the <strong>same</strong> as register.</li>
<li>Keep the user session data in the browser&rsquo;s <strong>session storage</strong>.</li>
<li>That <strong>includes</strong> the subscriptions array. Since local/session storage <strong>only</strong> keeps <strong>strings</strong> the array must be <strong>stringified </strong>or <strong>kept</strong> as a variable and <strong>updated</strong> on every init.</li>
<li>Clear <strong>all</strong> input fields after <strong>successful</strong></li>
</ul>
<h3>Logout (5 pts)</h3>
<p>Successfully logged in user should be able to <strong>logout</strong> from the app.</p>
<ul>
<li>After a <strong>successful</strong> logout, a <strong>notification</strong> message &ldquo;Logout successful.&rdquo; should be displayed.</li>
<li>After successful logout, the <strong>Sign </strong><strong>In screen</strong> should be shown.</li>
<li>The <strong>&ldquo;logout&rdquo; REST service</strong> at the back-end should be obligatory called at logout.</li>
<li>All local information in the browser (<strong>user session data</strong>) about the current user should be deleted.</li>
</ul>
<h3>Main Feed/Home Screen (20 pts)</h3>
<p>Successfully logged users should be welcomed by the <strong>feed</strong> screen which can be accessed <strong>after</strong> clicking the <strong>[Home]</strong> link in the <strong>navbar</strong>. The feed <strong>screen</strong> contains all chirps from <strong>subscriptions or people that the user is following </strong>(sorted by time posted in descending). It also contains the <strong>create</strong> a chirp <strong>form</strong>.</p>
<ul>
<li>The <strong>chirps</strong> should be listed in the <strong>format</strong> as shown in the Web design (see the screenshot below).</li>
<li>Each <strong>chirp</strong> has <strong>text</strong>, <strong>author</strong> and information about <strong>when</strong> it was <strong>created</strong>. For the <strong>time created</strong> information you will use a helper function given <strong>below</strong>. It requires a <strong>parameter</strong> which is the entity creation date of the post (or <strong>ect </strong>property of the post object).</li>
<li>When the <strong>follower username</strong> link is clicked, your app should <strong>redirect </strong>to the individual feed page of the user.</li>
<li>The feed screen should also contain <strong>information</strong> about the <strong>count</strong> all of all chirps that the user has <strong>posted</strong>, number of people that the user is <strong>following</strong>, and number of <strong>followers</strong> that the user has.</li>
<li>In case of <strong>error</strong> (e.g. Internet connection lost), an error message should be displayed.</li>
<li>In case of <strong>no chirps</strong>, display &lsquo;No chirps in database&rsquo;.</li>
</ul>
<p>If the user isn&rsquo;t following anyone, display the following:</p>
<ul>
<li>Format the entity creation <strong>date</strong> of a <strong>chirp</strong> as shown in the screenshot above. You may <strong>use</strong> the following helper function:</li>
</ul>
<table>
<tbody>
<tr>
<td width="1301">
<p><strong>function </strong><em>calcTime</em>(dateIsoFormat) {<br /> &nbsp;&nbsp;&nbsp; <strong>let </strong>diff = <strong>new </strong>Date - (<strong>new </strong>Date(dateIsoFormat));<br /> &nbsp;&nbsp;&nbsp; diff = <strong><em>Math</em></strong>.floor(diff / 60000);<br /> &nbsp;&nbsp;&nbsp; <strong>if </strong>(diff &lt; 1) <strong>return </strong><strong>'less than a minute'</strong>;<br /> &nbsp;&nbsp;&nbsp; <strong>if </strong>(diff &lt; 60) <strong>return </strong>diff + <strong>' minute' </strong>+ <em>pluralize</em>(diff);<br /> &nbsp;&nbsp;&nbsp; diff = <strong><em>Math</em></strong>.floor(diff / 60);<br /> &nbsp;&nbsp;&nbsp; <strong>if </strong>(diff &lt; 24) <strong>return </strong>diff + <strong>' hour' </strong>+ <em>pluralize</em>(diff);<br /> &nbsp;&nbsp;&nbsp; diff = <strong><em>Math</em></strong>.floor(diff / 24);<br /> &nbsp;&nbsp;&nbsp; <strong>if </strong>(diff &lt; 30) <strong>return </strong>diff + <strong>' day' </strong>+ <em>pluralize</em>(diff);<br /> &nbsp;&nbsp;&nbsp; diff = <strong><em>Math</em></strong>.floor(diff / 30);<br /> &nbsp;&nbsp;&nbsp; <strong>if </strong>(diff &lt; 12) <strong>return </strong>diff + <strong>' month' </strong>+ <em>pluralize</em>(diff);<br /> &nbsp;&nbsp;&nbsp; diff = <strong><em>Math</em></strong>.floor(diff / 12);<br /> &nbsp;&nbsp;&nbsp; <strong>return </strong>diff + <strong>' year' </strong>+ <em>pluralize</em>(diff);<br /> &nbsp;&nbsp;&nbsp; <strong>function </strong><em>pluralize</em>(value) {<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>if </strong>(value !== 1) <strong>return </strong><strong>'s'</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>else return </strong><strong>''</strong>;<br /> &nbsp;&nbsp;&nbsp; }<br /> }</p>
</td>
</tr>
</tbody>
</table>
<ul>
<li>Ensure you handle properly all HTML <strong>special characters</strong>, e.g. the message text could hold "<em>Hi, &lt;peter&gt;</em>".</li>
</ul>
<h3>Post Chirp (10 pts)</h3>
<p>Logged in users can <strong>post</strong> chirps. Clicking the <strong>[Chirp]</strong> button should directly <strong>add</strong> a chirp into the <strong>kinvey</strong> database. A chirp has <strong>text</strong> and <strong>author</strong>.</p>
<ul>
<li>After a <strong>successful</strong> chirp creation, a notification message &ldquo;Chirp published.&rdquo; should be displayed and the <strong>user feed</strong> should be shown (the screen with all chirps posted by the <strong>currently logged</strong> user).</li>
<li>A chirp text shouldn&rsquo;t be <strong>empty</strong> and shouldn&rsquo;t contain more than <strong>150 symbols</strong>.</li>
<li>Clear the <strong>create</strong> chirp input <strong>field</strong> after <strong>successful</strong> creation.</li>
<li>Ensure you handle properly all HTML <strong>special characters</strong>, e.g. the message text could hold "<em>Hi, &lt;peter&gt;</em>".</li>
</ul>
<p>After <strong>successful</strong> creation the <strong>user feed</strong> should be displayed. It can also be accessed by clicking the [<strong>Me</strong>] link in the <strong>navbar</strong>:</p>
<h3>User Feed (15 pts)</h3>
<p>Logged in users can view <strong>individual</strong> feeds (profile page). The <strong>currently logged</strong> user has an individual feed page where he can view his own chirps, <strong>create</strong> a chirp and delete his own <strong>chirps</strong>. Each logged in user can <strong>access</strong> their own feed by clicking the [<strong>Me</strong>] link.</p>
<ul>
<li>After a <strong>successful</strong> chirp creation, a notification message &ldquo;Chirp published.&rdquo; should be displayed and the <strong>user feed</strong> should be shown again.</li>
<li>The <strong>user feed</strong> screen should also contain <strong>information</strong> about the <strong>count</strong> all of all chirps that the user has <strong>posted</strong>, number of people that the user is <strong>following</strong>, and number of <strong>followers</strong> that the user has.</li>
<li>All chirps are listed in <strong>descending</strong> by time <strong>creation</strong>.</li>
<li>In case of <strong>no chirps</strong>, display &lsquo;No chirps in database&rsquo;.</li>
<li>In case of <strong>error</strong> (e.g. Internet connection lost), an error message should be displayed.</li>
</ul>
<p><strong>My own feed page:</strong></p>
<p><strong>Another user&rsquo;s feed page:</strong></p>
<p>The <strong>button</strong> on the top left of the screen can be either <strong>Follow</strong> or <strong>Unfollow </strong>depending on if the user&rsquo;s username is in the <strong>subscriptions</strong> array.</p>
<h3>Delete Chirp (5 pts)</h3>
<p>Authors <strong>should</strong> be able to <strong>delete</strong> their <strong>own</strong> chirps by clicking the [<strong>delete</strong>] button on each individual chirp.</p>
<ul>
<li>After <strong>successful</strong> post delete a notification message &ldquo;<strong>Chirp deleted.</strong>&rdquo; should be displayed and the <strong>user feed</strong> should be shown again.</li>
<li>In case of <strong>error</strong> (e.g. Internet connection lost / unauthorized request / missing message), an error message should be displayed.</li>
<li>Deleting works immediately, with <strong>no confirmation</strong>.</li>
</ul>
<h3>Discover People Screen (15 pts)</h3>
<p>In order to <strong>follow</strong>/<strong>unfollow</strong> people we must first <strong>find</strong> them. Implement a page where all users are <strong>listed</strong> and can be followed. By clicking the [<strong>Discover</strong>] link from the navigation the <strong>following</strong> screen should be displayed:</p>
<ul>
<li>These are all of the <strong>users</strong> in the database <strong>except</strong> the currently logged.</li>
<li>Clicking on the username should <strong>redirect</strong> to the user&rsquo;s feed page</li>
<li>Next to <strong>each</strong> username is the number of <strong>followers</strong> that the user has.</li>
<li>In case of <strong>error</strong> (e.g. Internet connection lost / unauthorized request / missing message), an error message should be displayed.</li>
</ul>
<h3>Follow User (5 pts)</h3>
<p>Logged in users can <strong>follow</strong> other users by clicking on the [<strong>Follow</strong>] link on each user <strong>feed page</strong>.</p>
<ul>
<li>After a <strong>successful</strong> following, a notification message &ldquo;<strong>Subscribed to {username}</strong>&rdquo; should be <strong>displayed</strong> and the <strong>user feed</strong> should be shown again with <strong>updated</strong></li>
<li>The <strong>username</strong> of the <strong>newly</strong> followed user should be added in the <strong>subscriptions</strong> array of the currently logged in user.</li>
<li>In case of <strong>error</strong> (e.g. Internet connection lost / unauthorized request / missing message), an error message should be displayed.</li>
</ul>
<h3>Unfollow User (5 pts)</h3>
<p>Logged in users can <strong>unfollow</strong> other users by clicking on the [<strong>Unfollow</strong>] link on each user <strong>feed page</strong>.</p>
<ul>
<li>After a <strong>successful</strong> unfollow, a notification message &ldquo;<strong>Unsubscribed to {username}</strong>&rdquo; should be <strong>displayed</strong> and the <strong>user feed</strong> should be shown again with <strong>updated</strong></li>
<li>The <strong>username</strong> of the <strong>newly</strong> followed user should be <strong>removed</strong> from the <strong>subscriptions</strong> array of the currently logged in user.</li>
<li>In case of <strong>error</strong> (e.g. Internet connection lost / unauthorized request / missing message), an error message should be displayed.</li>
</ul>
<h2>Problem 5.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Subtmitting Your Solution</h2>
<p>Place in a ZIP file your project folder. Exclude the node_modules folder. Upload the archive to the Judge.</p>