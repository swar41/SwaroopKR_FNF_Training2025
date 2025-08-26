document.getElementById("myForm").addEventListener("submit", function (e) {
  e.preventDefault(); 

  let messages = [];
  let username = document.getElementById("username").value;
  let pin = document.getElementById("pin").value;
  let state = document.getElementById("state").value;
  let validatePin = document.getElementById("validatePin").checked;
  let testMe = document.getElementById("testMe").checked;
  let radios = document.getElementsByName("product");
  let selectedRadio = Array.from(radios).find(r => r.checked);

  if (!/^[a-zA-Z0-9]{6,8}$/.test(username)) {
    messages.push("Username <form field not validated>");
  }

  if (validatePin && pin.trim() === "") {
    messages.push("PIN <form field not validated>");
  }

  if (state === "") {
    messages.push("State <form field not validated>");
  }

  if (!selectedRadio) {
    messages.push("Product selection <form field not validated>");
  }

  messages.push(`Test Me is ${testMe ? "checked" : "unchecked"}`);

  if (messages.some(msg => msg.includes("<form field not validated>"))) {
    alert(messages.join("\n"));
  } else {
    alert("Form validated successfully!\n" + messages[messages.length - 1]);
    window.location.href = "success.html";
  }
});
