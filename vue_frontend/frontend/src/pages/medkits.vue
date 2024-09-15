<script setup>
import axios from 'axios';
import { ref, onMounted } from 'vue'
import Dialog from '@/components/Dialog.vue';
let data = ref();
async function Fetch() {
    await axios.get("http://192.168.0.4:5112/all").then(res => {
        data.value = res.data;
    })
}
onMounted(async () => {
    await Fetch()
})
</script>
<template>
    <v-app>
        <v-row>
            <v-col>
                <Dialog :text="'Dodaj apteczke'" :button_text="'Dodaj apteczke'" :color="'red'"
                    :text_for_snackbar="'Dodano apteczke'" :button_look="'test'" :parameters="'test'">
                </Dialog>
                <v-data-table width="90%" density="compact" :items="data" hover show-expand item-value="uuid" :headers="[
                    { title: 'Id', value: 'id', key: 'id', align: 'start', },
                    { title: 'Adress IP', value: 'ip_address', key: 'ip_address', align: 'center', },
                    { title: 'Utworzono', value: 'created_at', key: 'created_at', align: 'center', },
                ]" item-key="id">
                    <template v-slot:item.id="{ item }">
                        <div>
                            {{ item.id }}
                        </div>
                    </template>
                    <template v-slot:item.ip_address="{ item }">
                        <div>
                            {{ item.ip_address }}
                        </div>
                    </template>
                    <template v-slot:item.created_at="{ item }">
                        <div>
                            {{ item.created_at }}
                        </div>
                    </template>
                </v-data-table>
            </v-col>
        </v-row>
        <v-row>
            <v-col>
            </v-col>
        </v-row>
    </v-app>
</template>