<template>
  <v-app>
    <AppHeader></AppHeader>
    <v-main>
      <router-view />
    </v-main>
  </v-app>
</template>

<script setup>
import AppHeader from '@/components/AppHeader.vue';
</script>
