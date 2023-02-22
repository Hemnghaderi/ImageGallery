const validate_firstName = (e) => {
    const regex = /^[a-zA-Z]+$/

    if (regex.test(e.target.value)) {
        document.querySelector('[data-valmsg-For="FirstName"]').innerHTML = ""
    } else {
        document.querySelector('[data-valmsg-For="FirstName"]').innerHTML = "Must be a valid name"
    }
}

const validate_lastName = (e) => {
    const regex = /^[a-zA-Z]+$/

    if (regex.test(e.target.value)) {
        document.querySelector('[data-valmsg-For="LastName"]').innerHTML = ""
    } else {
        document.querySelector('[data-valmsg-For="LastName"]').innerHTML = "Must be a valid name"
    }
}

const validate_email = (e) => {
    const regex = /^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/

    if (regex.test(e.target.value)) {
        document.querySelector('[data-valmsg-For="Email"]').innerHTML = ""
    } else {
        document.querySelector('[data-valmsg-For="Email"]').innerHTML = "Must be a valid email"
    }
}

const validate_password = (e) => {
    const regex = /^(?=.*[0-9])(?=.*[!@#$%^&*])[a-zA-Z0-9!@#$%^&*]{8,}$/

    if (regex.test(e.target.value)) {
        document.querySelector('[data-valmsg-For="Password"]')[0].innerHTML = ""
    } else {
        document.querySelector('[data-valmsg-For="Password"]')[0].innerHTML = "Must be a valid password"
    }
}
