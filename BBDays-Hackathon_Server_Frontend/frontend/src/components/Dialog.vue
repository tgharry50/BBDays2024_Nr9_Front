<!-- eslint-disable no-unused-vars -->
<script setup>
import { ref, watch, inject } from 'vue'
const host = inject('$hostname');
import axios from 'axios';
let ip_address = ref('');
const emit = defineEmits(['refreshdeleted']);
const timeout = ref(2000)
const dialog = ref(false)
const props = defineProps({
    text: String,
    title: String,
    button_text: String,
    icon: String,
    color: String,
    size: String,
    class: String,
    button_look: String,
    text_for_snackbar: String,
    parameters: Object,
})
const showSnackbar = ref(false); const snackbar_background = ref(''); const error_text = ref(''); const error = ref(false)
watch(dialog, () => {
    if (dialog.value === false) {

    }
})
async function Fetch() {
    await axios.post("http://192.168.0.4:5112/create", { ip_address: ip_address.value }).then(res => {
        console.log(res)
    })
}
</script>
<template>
    <div class="pa-4 text-center">
        <v-dialog v-model="dialog" max-width="600">
            <template v-slot:activator="{ props: activatorProps }">
                <v-btn :class="`text-none ${props.class}`" :prepend-icon="icon" :variant="button_look" :color="color"
                    v-bind="activatorProps">{{ props.button_text }}</v-btn>
            </template>

            <v-card :prepend-icon="icon" :title="title">
                <v-card-text class="mt-3">
                    <v-row>
                        <v-col>
                            <p>Wypełnij poniższe pole aby dodać apteczke</p>
                        </v-col>
                    </v-row>
                    <v-row>
                        <v-col>
                            <v-text-field label="Adres IP" v-model="ip_address">
                            </v-text-field>
                        </v-col>
                    </v-row>
                </v-card-text>
                <v-divider></v-divider>

                <v-card-actions>
                    <v-spacer></v-spacer>

                    <v-btn class="" text="Zamknij" variant="plain" @click="dialog = false"></v-btn>

                    <v-btn class="" @click="Fetch()" color="red" text="Dodaj" variant="outlined"></v-btn>
                </v-card-actions>
            </v-card>
        </v-dialog>
    </div>
    <v-snackbar v-model="showSnackbar" :timeout="timeout" :color="snackbar_background">
        <p v-if="!error">{{ text_for_snackbar }}</p>
        <p v-else>{{ error_text }}</p>

        <template v-slot:actions>
            <v-btn color="light-green-lighten-2" variant="text" @click="showSnackbar = false">
                <span style="color: black">Zamknij</span>
            </v-btn>
        </template>
    </v-snackbar>
</template>
