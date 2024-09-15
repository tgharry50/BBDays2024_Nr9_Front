<script setup>
import axios from 'axios';
import { ref } from 'vue'
let login = ref(''); let password = ref('');
let first_name = ref(''); let last_name = ref('');
let isValid = ref(false);
const Rules = {
    Required: v => !!v || 'Pole jest wymagane'
}
async function post() {
    const form = new FormData()
    form.append("login", login.value)
    form.append("password", password.value)
    form.append("first_name", first_name.value)
    form.append("last_name", last_name.value)

    axios.post("http://192.168.0.4:5112/register", form).then(res => {
        console.log(res)
    })
}
</script>

<template>
    <v-app>
        <v-card class="mx-auto mt-5 px-6 py-8 w-50">
            <v-form v-model="isValid">
                <v-row>
                    <v-col>
                        <v-text-field :rules="[Rules.Required]" v-model="login" class="mb-2" label="Login"
                            clearable></v-text-field>

                        <v-text-field :rules="[Rules.Required]" v-model="first_name" label="Imię" placeholder="..."
                            clearable></v-text-field>
                    </v-col>
                    <v-col>
                        <v-text-field :rules="[Rules.Required]" v-model="password" class="mb-2" label="Hasło"
                            clearable></v-text-field>
                        <v-text-field :rules="[Rules.Required]" v-model="last_name" label="Nazwisko" placeholder="..."
                            clearable></v-text-field>
                    </v-col>
                </v-row>
                <br>
                <v-btn color="success" @click="post()" :disabled="!isValid" size="large" variant="elevated" block>
                    Zarejestruj się
                </v-btn>
            </v-form>
        </v-card>
    </v-app>
</template>