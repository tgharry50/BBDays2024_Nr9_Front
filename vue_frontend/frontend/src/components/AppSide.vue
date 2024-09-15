<script setup>
import { useRouter } from 'vue-router'
const router = useRouter();
</script>
`<template>
    <v-navigation-drawer class="text-center">
        <!-- USER PROFILE -->
        <v-list class="text-h5">
            <v-list-item>
                <p>USER TYPE</p>
                <p>NAME</p>
                <p>SURNAME</p>
            </v-list-item>
        </v-list>
        <v-divider></v-divider>
        <!-- INDEX -->
        <v-list class @click="router.push('/')">
            <h3>Strona główna</h3>
        </v-list>
        <v-divider></v-divider>
        <!-- MEDKIT -->
        <v-list @click="router.push('/medkits')">
            <h3>Apteczki</h3>
        </v-list>
        <v-divider></v-divider>
        <!-- PROFILE -->
        <v-list @click="router.push('/profile')">
            <h3>Profil</h3>
        </v-list>
        <v-divider></v-divider>
        <!-- LOGIN -->
        <v-list @click="router.push('/login')">
            <h3>Zaloguj się</h3>
        </v-list>
        <v-divider></v-divider>
        <!-- REGISTER -->
        <v-list @click="router.push('/registers')">
            <h3>Zarejestruj się</h3>
        </v-list>
        <v-divider></v-divider>
        <!-- LOGOUT -->
        <v-list>
            <h3>Wyloguj się</h3>
        </v-list>
    </v-navigation-drawer>
</template>