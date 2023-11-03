import React, { useEffect, useState } from 'react';

const Users =()=> {
    const [users, setUsers] = useState([]);

    useEffect(() => {
        // Fetch the list of users from your API.
        fetch(' /api/Users/GetUsers')
            .then((response) => response.json())
            .then((data) => setUsers(data))
            .catch((error) => console.error('Error fetching users:', error));
    }, []);

    return (
        <div>
            <h2>Users List</h2>
            <ul>
                {users.map((user) => (
                    <li key={user.id}>
                        <strong>Name:</strong> {user.name}, <strong>Email:</strong> {user.email}
                    </li>
                ))}
            </ul>
        </div>
    );
}

export default Users;