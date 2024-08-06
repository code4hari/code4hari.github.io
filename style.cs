body {
    font-family: 'Montserrat', sans-serif;
    margin: 0;
    padding: 0;
    line-height: 1.6;
    background-color: #f4f4f4;
    color: #333;
}

header {
    background-color: #333;
    color: #fff;
    padding: 15px 0;
    text-align: center;
    position: fixed;
    width: 100%;
    top: 0;
    z-index: 1000;
    box-shadow: 0 2px 5px rgba(0, 0, 0, 0.2);
}

header h1 {
    margin: 0;
    font-weight: 600;
}

header ul {
    list-style: none;
    padding: 0;
}

header ul li {
    display: inline;
    margin: 0 15px;
}

header ul li a {
    color: #fff;
    text-decoration: none;
    font-weight: 600;
    transition: color 0.3s ease;
}

header ul li a:hover {
    color: #1abc9c;
}

#hero {
    background: linear-gradient(rgba(0, 0, 0, 0.7), rgba(0, 0, 0, 0.7)), url('hero-image.jpg') no-repeat center center/cover;
    height: 100vh;
    display: flex;
    justify-content: center;
    align-items: center;
    color: #fff;
    text-align: center;
}

.hero-content h2 {
    font-size: 2.5rem;
    margin-bottom: 20px;
    animation: fadeInUp 1s ease-in-out;
}

.hero-content p {
    font-size: 1.25rem;
    margin-bottom: 30px;
    animation: fadeInUp 1.5s ease-in-out;
}

.btn {
    padding: 10px 20px;
    background-color: #1abc9c;
    color: #fff;
    text-decoration: none;
    font-weight: 600;
    border-radius: 5px;
    transition: background-color 0.3s ease;
    animation: fadeInUp 2s ease-in-out;
}

.btn:hover {
    background-color: #16a085;
}

section {
    padding: 60px 20px;
    margin-top: 60px;
    background-color: #fff;
    border-radius: 8px;
    box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
}

h2 {
    margin-top: 0;
    color: #333;
    font-weight: 600;
}

.job, .project {
    margin-bottom: 20px;
}

ul {
    padding-left: 20px;
}

footer {
    text-align: center;
    padding: 20px 0;
    background-color: #333;
    color: #fff;
    position: relative;
}

footer a {
    color: #1abc9c;
    text-decoration: none;
    transition: color 0.3s ease;
}

footer a:hover {
    color: #16a085;
}

.social-icons {
    margin-top: 10px;
}

.social-icons a {
    color: #fff;
    margin: 0 10px;
    font-size: 1.5rem;
    transition: color 0.3s ease;
}

.social-icons a:hover {
    color: #1abc9c;
}

@keyframes fadeInUp {
    0% {
        opacity: 0;
        transform: translateY(20px);
    }
    100% {
        opacity: 1;
        transform: translateY(0);
    }
}

.fade-in {
    opacity: 0;
    animation: fadeIn 2s ease-in forwards;
}

@keyframes fadeIn {
    to {
        opacity: 1;
    }
}
