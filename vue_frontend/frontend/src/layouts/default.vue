<template>
  <v-app>
    <AppHeader></AppHeader>
    <AppSide></AppSide>
    <v-main>
      <router-view />
    </v-main>
  </v-app>
</template>

<script setup>
import AppHeader from '@/components/AppHeader.vue';
import AppSide from '@/components/AppSide.vue';
</script>
