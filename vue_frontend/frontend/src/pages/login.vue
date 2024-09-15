<script setup>
import { ref } from 'vue'
import axios from 'axios';
let login = ref(); let password = ref();
let isValid = ref(false);
const Rules = {
    Required: v => !!v || 'Pole jest wymagane'
}
async function post() {
    const form = new FormData()
    form.append("login", login.value)
    form.append("password", password.value)
    axios.post("http://192.168.0.4:5112/login", form).then(res => {
        console.log(res)
    })
}
</script>

<template>
    <v-app>
        <v-card class="mx-auto mt-5 px-6 py-8 w-50">
            <v-form v-model="isValid">
                <v-text-field :rules="[Rules.Required]" v-model="login" class="mb-2" label="Login"
                    clearable></v-text-field>

                <v-text-field :rules="[Rules.Required]" v-model="password" label="Hasłó" placeholder="..."
                    clearable></v-text-field>

                <br>

                <v-btn color="success" :disabled="!isValid" size="large" @click="post" variant="elevated" block>
                    Zaloguj się
                </v-btn>
            </v-form>
        </v-card>
    </v-app>
</template>