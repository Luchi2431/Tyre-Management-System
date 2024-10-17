import { Box, Button, Container, Grid, Paper, TextField, Typography } from "@mui/material";
import axios from "axios";
import { useState } from "react";
import Link from "@mui/material/Link";
import { Navigate, useNavigate } from 'react-router-dom';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';

const Login = () => {
    const [username, setUsername] = useState(''); 
    const [password, setPassword] = useState(''); 
    const navigate = useNavigate();

    const loginHandler = (event) => {
        event.preventDefault();
        console.log('fja');
        
        axios.post(
            "https://localhost:3000/User/login",
            {
                username: username, 
                password: password 
            },
            {
                headers: {}
            }
        )
        .then((response) => {
            console.log('id', response.data.id);
            localStorage.setItem('token', response.data.jwtToken);
            localStorage.setItem('id', response.data.id);

            if (username.includes('Supervisor')) {
                navigate('/QualitySupervisor ');
            } else if (username.includes('Operator')) {
                navigate('/ProductionOperator');
            } else {
                navigate('/BusinessUnitLeader ');
            }
        })
        .catch((error) => {
            
            console.log("error", error.response.data);
        });
    }

    

    const usernameHandler = (event) => {
        const newUsername = event.target.value;
        setUsername(newUsername);
    }

    const passwordHandler = (event) => {
        const newPassword = event.target.value;
        setPassword(newPassword);
    }

    return (
        <>
            <Grid
                container
                spacing={0}
                direction="column"
                alignItems="center"
                justifyContent="center"
                style={{ minHeight: '100vh' }}
            >
                <Container component="main" maxWidth="xs" alignItems="center" justifyContent="center">
                    <Paper elevation={24}>
                        <Box
                            sx={{
                                marginTop: 8,
                                display: "flex",
                                flexDirection: "column",
                                alignItems: "center",
                            }}
                        >
                            <Typography component="h1" variant="h3">
                                LogIn
                            </Typography>
                            <Box component="form" noValidate sx={{ mt: 1 }}>
                                <TextField
                                    margin="normal"
                                    required
                                    fullWidth
                                    id="username"
                                    label="Username"
                                    name="username" 
                                    autoComplete="username"
                                    autoFocus
                                    onChange={usernameHandler}
                                />
                                <TextField
                                    margin="normal"
                                    required
                                    fullWidth
                                    name="password"
                                    label="Password"
                                    type="password"
                                    id="password"
                                    autoComplete="current-password"
                                    onChange={passwordHandler}
                                />
                                <Button
                                    type="submit"
                                    fullWidth
                                    variant="contained"
                                    sx={{ mt: 3, mb: 2 }}
                                    onClick={loginHandler}
                                >
                                    LogIn
                                </Button>
                                <Grid container sx={{ mt: 5, mb: 5 }}
                                    justifyContent="center"
                                    alignItems="center">
                                  
                                      
                                    
                                </Grid>
                            </Box>
                        </Box>
                    </Paper>
                </Container>
            </Grid>
        </>
    );
}

export default Login;