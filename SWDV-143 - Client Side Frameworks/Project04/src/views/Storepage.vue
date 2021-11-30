<template>
    <div>
        <div class="container bg-dark mt-3">
            <div class="row justify-content-center">

                    <label class="form-label h2 text-white mt-3 ml-auto">Featured Apparel</label>
                    
                <nav class="navbar navbar-dark bg-dark ml-auto">
                    <div class="navbar-dark ml-auto d-flex justify-content-end pb-4">
                        <div  class="mr-auto d-flex align-items-end flex-column bd-highlight position-absolute" >
                            <div class="mb-2">

                                <!-- <button @click="displayCart= !displayCart" class="btn btn-success btn-sm ml-3" 
                                    id="cartDropdown" aria-haspopup="true" aria-expanded="false">
                                <i class="fas fa-shopping-cart mr-1"></i>
                                    {{cart.length}}
                                </button> -->

                                <a href="#cart" ><button class="btn btn-success btn-sm ml-3">
                                <i class="fas fa-shopping-cart mr-1"></i>
                                    {{cart.length}}
                                </button></a>

                            </div>
                        </div>
                    </div> 
                </nav>

                

                <div v-for="(item) in filteredProducts" :key="item.id" id="item-list" class="row d-flex my-2 align-items-center mx-4 p-2">
                    <div class="col-lg-1 col-md-2 col-sm-3">
                        <button @click="addToCart(item)" class="btn btn-white ml-4">+</button>
                    </div>
                    <div class="col-lg-4 col-md-2 col-sm-3" >
                        <img class="img-fluid d-block border border-secondary" :src="getImgUrl(item.image)" :alt="item.name">
                    </div>
                    <div class="col-lg-7 col-md-8 col-sm-6 border border-secondary p-2">
                        <h3 class="text-white">{{item.name}}</h3>
                        <p class="mb-0 text-white">{{item.description}}</p>
                        <br>
                        <div class="h5 float-right">

                            <span class="badge bg-success" v-if="(item.price<100 && item.price>50) && displayLabels">Best Seller</span>
                            <span class="badge bg-danger" v-else-if="item.price<=50 && displayLabels">On Sale!</span>
                            <pricetocurrency :amt="item.price"></pricetocurrency>
                        </div> 

                    </div>

                </div>
                <div class="badge bg-dark my-3 text-white"> Total Results: {{ filteredProducts.length}}</div>
            </div>
        </div>

        <div class="container bg-dark mt-5">
            <div class="justify-content-center">

                    <h2 class="text-white pt-3 mb-2" id="cart">Cart</h2>
                    <p v-if="cart.length<1" class="text-white pt-3 pb-5"> Cart Empty! </p>

                    <section v-else class="container mt-5">
                        <div class="col mt-5">
                            <div v-for="(item, index) in cart" :key="index" class="bg-secondary mt-3 list-group-item d-flex justify-content-between">
                                <div class="col-3">
                                    <img class="img-fluid d-block" :src="getImgUrl(item.image)" :alt="item.name">
                                </div>
                                <div class="col-5 text-white">{{item.name}}</div>
                                <div class="col-4 font-weight-bold"><pricetocurrency :amt="item.price"></pricetocurrency></div>
                            </div>
                        </div>
                        <button class="btn btn-success mt-5 mb-5">Checkout</button>
                    </section>
            </div>
        </div>
        <br><br>
    </div>
</template>

<script>
import PriceToCurrency  from '../components/PriceToCurrency.vue'

export default {
    data() {
        return {
        displayCart: false,
        displayLabels: true,
        cart: [],
        products : [
                {
                "id": "001",
                "name": "Insulated Boots",
                "description": "The best insulated boots on the market at this price point. Provides great arch support for those long hikes that don't require that you get your feet wet. Come into the store to try them out!",
                "price": "45",
                "image": "slide1.jpg"
                },
                {
                "id": "101",
                "name": "Backpacking Tent",
                "description": "A great basic tent for when you camp in areas that are not sub-freezing. Light enough to use backpacking. Comes with a rain fly, stakes, and pouch to contain everything in. Grab it fast, this one always sells out first.",
                "price": "99",
                "image": "slide2.jpg"
                },
                {
                "id": "201",
                "name": "Backpacking Backpack",
                "description": "The best backpacking backpack that supports your back. Long hikes will become a breeze. It has compartments for a sleeping bag, easy access to the main area, and a snack pouch on top. It also includes straps for a foam roll.",
                "price": "120",
                "image": "slide3.jpg"
                },
                {
                "id": "301",
                "name": "Basic Compass",
                "description": "This is the perfect compass for when you get lost. It may not have all of the fancy trinkets that the more expensice units have, but this thing will last white maintaining its pinpoint accuracy",
                "price": "20",
                "image": "slide4.jpg"
                }
            ]
        }
    },
    computed: {
        filteredProducts() {
        return this.products.filter(item => (item.price))
        },
        cartTotal() {
        return this.cart.reduce((inc, item) => Number(item.price) + inc, 0)
        }
    },

    components: {
        'pricetocurrency' : PriceToCurrency
    },
    methods: {
        addToCart(product) {
        this.cart.push(product)
        },
        getImgUrl(imgName) {
        return require('../media/'+imgName)
        }

    },
}
</script>