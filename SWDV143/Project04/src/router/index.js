import { createRouter, createWebHistory } from 'vue-router'
import Home from '../views/Homepage.vue'
import About from '../views/Aboutpage.vue'
import Store from '../views/Storepage.vue'

const routes = [
  {
    path: '/',
    name: 'Home',
    component: Home
  },
  {
    path: '/about',
    name: 'About',
    component: About
  },
  {
    path: '/store',
    name: 'Store',
    component: Store
  }
]

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes
})

export default router
