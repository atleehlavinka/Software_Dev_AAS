<template>
    <nav class="family-sans text-uppercase navbar navbar-expand-md navbar-dark">
        <div class="container-fluid">

            <router-link class="" to="/"><a class="navbar-brand text-dark"><img class="icon" src="../media/logo3.png"></a>HOME</router-link>
                            
            <nav class="navbar navbar-light sticky-top ml-auto">
                <ul class="navbar-nav">
                    <li class="nav-item">
                        <router-link class="" to="/about"> About </router-link>&nbsp;&nbsp;&nbsp;
                    </li>
                
                    <!-- <li class="nav-item">
                        <router-link class="" to="/about"> Contact </router-link> &nbsp;&nbsp;&nbsp;
                    </li> -->
                
                    <li class="nav-item">
                        <router-link class="" to="/store"> Store </router-link>
                    </li>
                
                </ul>
            </nav>
        </div>
    </nav>
</template>
