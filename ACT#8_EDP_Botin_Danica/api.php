<?php
header("Content-Type: application/json");

$host = 'localhost';
$db = 'hr';
$user = 'root';
$pass = 'danica';
$charset = 'utf8mb4';

$dsn = "mysql:host=$host;dbname=$db;charset=$charset";
$options = [
    PDO::ATTR_ERRMODE => PDO::ERRMODE_EXCEPTION,
    PDO::ATTR_DEFAULT_FETCH_MODE => PDO::FETCH_ASSOC,
    PDO::ATTR_EMULATE_PREPARES => false,
];

$pdo = new PDO($dsn, $user, $pass, $options);

if ($_SERVER['REQUEST_METHOD'] === 'GET') {
    $stmt = $pdo->query("SELECT userid, username, pass, email FROM accounts");
    $users = $stmt->fetchAll();
    echo json_encode($users);
} elseif ($_SERVER['REQUEST_METHOD'] === 'POST') {
    $input = json_decode(file_get_contents('php://input'), true);
    $sql = "INSERT INTO accounts (username, pass, email) VALUES (?, ?, ?)";
    $stmt = $pdo->prepare($sql);
    $stmt->execute([$input['username'], $input['pass'], $input['email']]);
    echo json_encode(['message' => 'User added successfully']);
}
?>