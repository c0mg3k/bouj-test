namespace SaraTest.Controllers {

    export class HomeController {
        public restaurants;

        constructor(private $http: ng.IHttpService) {
            this.$http.get(`/api/restaurants`).then((response) => {
                this.restaurants = response.data;
            })
        }
    }



    export class AboutController {
        public message = 'Hello from the about page!';
    }

}
