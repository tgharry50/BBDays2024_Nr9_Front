
// Plugins
import { registerPlugins } from '@/plugins'

// Components
import App from './App.vue'

// Composables
import { createApp } from 'vue'

const app = createApp(App)

registerPlugins(app)
app.provide('$hostname', 'http://0.0.0.0:5153')
app.mount('#app')
