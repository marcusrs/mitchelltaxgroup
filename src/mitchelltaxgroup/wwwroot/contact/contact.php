<?php
 
// Email address verification
function isEmail($email) {
    return filter_var($email, FILTER_VALIDATE_EMAIL);
}
 
if($_POST) {
 
    // Enter the email where you want to receive the message
    $emailTo = 'marcusshipman@yahoo.com';
 
    $clientEmail = addslashes(trim($_POST['email']));
    $subject = addslashes(trim($_POST['subject']));
    $message = addslashes(trim($_POST['message']));
 
    $array = array('emailMessage' => '', 'subjectMessage' => '', 'messageMessage' => '', 'antispamMessage' => '');
 
    if(!isEmail($clientEmail)) {
        $array['emailMessage'] = 'Invalid email!';
    }
    if($subject == '') {
        $array['subjectMessage'] = 'Empty subject!';
    }
    if($message == '') {
        $array['messageMessage'] = 'Empty message!';
    }
    if(isEmail($clientEmail) && $subject != '' && $message != '' && $antispam == '12') {
        // Send email
        $headers = "From: " . $clientEmail . " <" . $clientEmail . ">" . "\r\n" . "Reply-To: " . $clientEmail;
        mail($emailTo, $subject . " (bootstrap contact form tutorial)", $message, $headers);
    }
 
    echo json_encode($array);
 
}
 
?>
