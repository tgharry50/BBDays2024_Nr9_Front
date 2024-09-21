<template>
  <v-layout>
    <v-card class="mx-auto mt-5 px-6 py-8 w-50">
      <v-form v-model="isValid">
        <!-- TOP ROW -->
        <v-row>
          <v-col>
            <v-checkbox v-model="bandage" label="Bandaż zwykły"></v-checkbox>
          </v-col>
          <v-col>
            <v-checkbox v-model="elastic" label="Bandaż elastyczny"></v-checkbox>
          </v-col>
          <v-col>
            <v-checkbox v-model:focused="splint" label="Szyna typu splint"></v-checkbox>
          </v-col>
        </v-row>
        <!-- MIDDLE ROW -->
        <v-row>
          <v-col>
            <v-checkbox v-model="wound_plaster" label="Plaster na rany"></v-checkbox>
          </v-col>
          <v-col>
            <v-checkbox v-model="disenfectant" label="Środek dezynfekujący"></v-checkbox>
          </v-col>
          <v-col>
            <v-checkbox v-model="nrc" label="Folia NRC"></v-checkbox>
          </v-col>
        </v-row>
        <!-- MIDDLE ROW 2 -->
        <v-row>
          <v-col>
            <v-checkbox v-model="rko" label="Maska RKO"></v-checkbox>
          </v-col>
          <v-col>
            <v-checkbox v-model="blood" label="Zestaw na kleszcze"></v-checkbox>
          </v-col>
          <v-col>
            <v-checkbox v-model="latex" label="Rękawiczki lateksowe"></v-checkbox>
          </v-col>
        </v-row>
        <!-- END ROW -->
        <v-row>
          <v-col>
            <v-checkbox v-model="wound_dust" label="Proszek na rany"></v-checkbox>
          </v-col>
          <v-col>
            <v-checkbox v-model="medpack" label="Pakiet apteczny"></v-checkbox>
          </v-col>
        </v-row>
        <v-row>
          <v-col class="text-center">
            <v-btn color="green">Prześlij formularz</v-btn>
          </v-col>
        </v-row>
      </v-form>
    </v-card>
  </v-layout>
</template>
<script setup>
let bandage = ref(); let elastic = ref(); let splint = ref();
let wound_plaster = ref(); let disenfectant = ref(); let nrc = ref();
let rko = ref(); let blood = ref(); let latex = ref(); let wound_dust = ref();
let medpack = ref()

import axios from 'axios';
import { onMounted, ref } from 'vue';
async function ping() {
  let result = ref()
  await axios.post("http://192.168.0.3:80/login").then(res => {
    console.log(res.data)
    result.value = res.data;
  })
  await axios.post("http://192.168.0.4:5112/Index/index", result.value).then(res => {
    console.log(res.data)
  })
}
onMounted(() => {
  setInterval(async () => {
    await ping()
  }, 5000);
})
</script>
