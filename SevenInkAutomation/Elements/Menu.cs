using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SevenInkAutomation.Pages
{
    public class Menu
    {
        public Menu()
        {
            PageFactory.InitElements(Driver.driver, this);
        }                                       
        
        //Navbar
        [FindsBy(How = How.CssSelector, Using = "#ast-desktop-header > div.ast-main-header-wrap.main-header-bar-wrap > div > div > div > div.site-header-primary-section-left.site-header-section.ast-flex.site-header-section-left.logo-main > div.site-header-primary-section-left.site-header-section.ast-flex.site-header-section-left.logo-alt > div > span > a > img")]
        public IWebElement HomeLogo { get; set; }


        [FindsBy(How = How.Id, Using = "menu-item-3253")]
        public IWebElement AboutUs { get; set; }

        [FindsBy(How = How.Id, Using = "menu-item-3254")]
        public IWebElement OurExpertise { get; set; }

        [FindsBy(How = How.Id, Using = "menu-item-3255")]
        public IWebElement Insights { get; set; }

        [FindsBy(How = How.Id, Using = "menu-item-90")]
        public IWebElement ContactUs { get; set; }

        //Home
        [FindsBy(How = How.CssSelector, Using = "#post-3175 > div > div > section.elementor-section.elementor-top-section.elementor-element.elementor-element-6b79bd3d.animated-slow.section-hero.elementor-section-full_width.elementor-section-height-default.elementor-section-height-default > div > div > div > section > div > div.elementor-column.elementor-col-50.elementor-inner-column.elementor-element.elementor-element-10aa3c4b.hero-col2 > div > div.elementor-element.elementor-element-88ce935.container-btnbook.elementor-widget.elementor-widget-text-editor > div > a")]
        public IWebElement BookAMeeting { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > div.calendly-overlay > div.calendly-popup-close")]
        public IWebElement ModalBookX { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#post-3175 > div > div > section.elementor-section.elementor-top-section.elementor-element.elementor-element-6b79bd3d.animated-slow.section-hero.elementor-section-full_width.elementor-section-height-default.elementor-section-height-default > div > div > div > section > div > div.elementor-column.elementor-col-50.elementor-inner-column.elementor-element.elementor-element-10fc5a78.hero-col1 > div > div.elementor-element.elementor-element-58f19b85.btn-home.elementor-widget.elementor-widget-button > div > div > a")]
        public IWebElement GetStartedHomeButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#post-3175 > div > div > section.elementor-section.elementor-top-section.elementor-element.elementor-element-640bdc93.section-why.elementor-section-boxed.elementor-section-height-default.elementor-section-height-default > div > div.elementor-column.elementor-col-50.elementor-top-column.elementor-element.elementor-element-2806847c.col-why1 > div > div > div > img")]
        public IWebElement HomePicOne { get; set; }       

        [FindsBy(How = How.CssSelector, Using = "#post-3175 > div > div > section.elementor-section.elementor-top-section.elementor-element.elementor-element-640bdc93.section-why.elementor-section-boxed.elementor-section-height-default.elementor-section-height-default > div > div.elementor-column.elementor-col-50.elementor-top-column.elementor-element.elementor-element-2806847c.col-why1 > div > section > div > div.elementor-column.elementor-col-50.elementor-inner-column.elementor-element.elementor-element-463ff00b > div > div > div")]
        public IWebElement HomePicTwo { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#post-3175 > div > div > section.elementor-section.elementor-top-section.elementor-element.elementor-element-640bdc93.section-why.elementor-section-boxed.elementor-section-height-default.elementor-section-height-default > div > div.elementor-column.elementor-col-50.elementor-top-column.elementor-element.elementor-element-2806847c.col-why1 > div > section > div > div.elementor-column.elementor-col-50.elementor-inner-column.elementor-element.elementor-element-592c621f > div > div")]
        public IWebElement HomePicThree { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#post-3175 > div > div > section.elementor-section.elementor-top-section.elementor-element.elementor-element-640bdc93.section-why.elementor-section-boxed.elementor-section-height-default.elementor-section-height-default > div > div.elementor-column.elementor-col-50.elementor-top-column.elementor-element.elementor-element-1ef3578b.col-why2 > div > div.elementor-element.elementor-element-14a3bdeb.elementor-align-left.btn-home.elementor-widget.elementor-widget-button > div > div > a > span")]
        public IWebElement FindOutMoreHome { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#post-3175 > div > div > section.elementor-section.elementor-top-section.elementor-element.elementor-element-7a9d748f.elementor-section-full_width.section-what.section-slider.elementor-section-height-default.elementor-section-height-default > div > div > div > div.elementor-element.elementor-element-4d105364.elementor-widget.elementor-widget-heading > div > h2\r\n")]
        public IWebElement WhatWeCanDoForYouHome { get; set; }

        [FindsBy(How = How.Id, Using = "slide-next")]
        public IWebElement SlideNext { get; set; }

        [FindsBy(How = How.Id, Using = "slide-prev")]
        public IWebElement SlidePrev { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#post-3175 > div > div > section.elementor-section.elementor-top-section.elementor-element.elementor-element-7a9d748f.elementor-section-full_width.section-what.section-slider.elementor-section-height-default.elementor-section-height-default > div > div > div > div.elementor-element.elementor-element-4a24835d.sc_flower_code.elementor-widget.elementor-widget-shortcode > div > div > div > div > div > div.slide-container.s1.slick-slide.slick-current.slick-center > div > div > a > button")]
        public IWebElement FindOutMoreSlideOne { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#post-3175 > div > div > section.elementor-section.elementor-top-section.elementor-element.elementor-element-7a9d748f.elementor-section-full_width.section-what.section-slider.elementor-section-height-default.elementor-section-height-default > div > div > div > div.elementor-element.elementor-element-4a24835d.sc_flower_code.elementor-widget.elementor-widget-shortcode > div > div > div > div > div > div.slide-container.s2.slick-slide.slick-current.slick-center > div > div > a > button")]
        public IWebElement FindOutMoreSlideTwo { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#post-3175 > div > div > section.elementor-section.elementor-top-section.elementor-element.elementor-element-7a9d748f.elementor-section-full_width.section-what.section-slider.elementor-section-height-default.elementor-section-height-default > div > div > div > div.elementor-element.elementor-element-4a24835d.sc_flower_code.elementor-widget.elementor-widget-shortcode > div > div > div > div > div > div.slide-container.s3.slick-slide.slick-current.slick-center > div > div > a > button")]
        public IWebElement FindOutMoreSlideThree { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#post-3175 > div > div > section.elementor-section.elementor-top-section.elementor-element.elementor-element-7a9d748f.elementor-section-full_width.section-what.section-slider.elementor-section-height-default.elementor-section-height-default > div > div > div > div.elementor-element.elementor-element-4a24835d.sc_flower_code.elementor-widget.elementor-widget-shortcode > div > div > div > div > div > div.slide-container.s4.slick-slide.slick-current.slick-center > div > div > a > button")]
        public IWebElement FindOutMoreSlideFour { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#post-3175 > div > div > section.elementor-section.elementor-top-section.elementor-element.elementor-element-2ab0397f.section-insights.elementor-section-boxed.elementor-section-height-default.elementor-section-height-default > div > div > div > div.elementor-element.elementor-element-584ca1e1.elementor-widget.elementor-widget-heading > div > h2")]
        public IWebElement InsightTitle { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#post-3175 > div > div > section.elementor-section.elementor-top-section.elementor-element.elementor-element-29890645.section-articlehome.elementor-section-boxed.elementor-section-height-default.elementor-section-height-default > div > div.elementor-column.elementor-col-50.elementor-top-column.elementor-element.elementor-element-90d4cc.left-art > div > div > div > div > div > div.article-imgcontainer > div.img-container > a > img")]
        public IWebElement InsightsHomeOne { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#post-3175 > div > div > section.elementor-section.elementor-top-section.elementor-element.elementor-element-29890645.section-articlehome.elementor-section-boxed.elementor-section-height-default.elementor-section-height-default > div > div.elementor-column.elementor-col-50.elementor-top-column.elementor-element.elementor-element-22733dfc.right-art > div > div > div > div > div > div.article-imgcontainer > div.img-container > a > img")]
        public IWebElement InsightsHomeTwo { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#post-3175 > div > div > section.elementor-section.elementor-top-section.elementor-element.elementor-element-6dcbcb0.elementor-section-full_width.section-homebg.elementor-section-height-default.elementor-section-height-default > div > div.elementor-column.elementor-col-50.elementor-top-column.elementor-element.elementor-element-2054e16b.col-bgset1 > div > div > div > div > div > div")]
        public IWebElement HomeFlowerOne { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#post-3175 > div > div > section.elementor-section.elementor-top-section.elementor-element.elementor-element-6b79bd3d.animated-slow.section-hero.elementor-section-full_width.elementor-section-height-default.elementor-section-height-default > div > div > div > section > div > div.elementor-column.elementor-col-50.elementor-inner-column.elementor-element.elementor-element-10fc5a78.hero-col1 > div > div.elementor-element.elementor-element-591d9ec9.homebannerleft.homeleft.elementor-widget.elementor-widget-shortcode > div > div > div > div")]
        public IWebElement HomeFlowerTwo { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#post-3175 > div > div > section.elementor-section.elementor-top-section.elementor-element.elementor-element-6b79bd3d.animated-slow.section-hero.elementor-section-full_width.elementor-section-height-default.elementor-section-height-default > div > div > div > section > div > div.elementor-column.elementor-col-50.elementor-inner-column.elementor-element.elementor-element-10fc5a78.hero-col1 > div > div.elementor-element.elementor-element-4b5f1c1.homebannerleft.bot.elementor-widget.elementor-widget-shortcode > div > div > div > div")]
        public IWebElement HomeFlowerThree { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#post-3175 > div > div > section.elementor-section.elementor-top-section.elementor-element.elementor-element-6b79bd3d.animated-slow.section-hero.elementor-section-full_width.elementor-section-height-default.elementor-section-height-default > div > div > div > div > div > div > div > div")]
        public IWebElement HomeFlowerFour { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#post-3175 > div > div > section.elementor-section.elementor-top-section.elementor-element.elementor-element-640bdc93.section-why.elementor-section-boxed.elementor-section-height-default.elementor-section-height-default > div > div.elementor-column.elementor-col-50.elementor-top-column.elementor-element.elementor-element-1ef3578b.col-why2 > div > div.elementor-element.elementor-element-74520d75.f-whytrust.elementor-absolute.elementor-widget.elementor-widget-shortcode > div > div > div > div")]
        public IWebElement HomeFlowerFive { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#post-3175 > div > div > section.elementor-section.elementor-top-section.elementor-element.elementor-element-7a9d748f.elementor-section-full_width.section-what.section-slider.elementor-section-height-default.elementor-section-height-default > div > div > div > div.elementor-element.elementor-element-7a0b5f80.whatwecan.elementor-widget.elementor-widget-shortcode > div > div > div > div")]
        public IWebElement HomeFlowerSix { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#post-3175 > div > div > section.elementor-section.elementor-top-section.elementor-element.elementor-element-7a9d748f.elementor-section-full_width.section-what.section-slider.elementor-section-height-default.elementor-section-height-default > div > div > div > div.elementor-element.elementor-element-3d9beeb6.whatwecan.elementor-widget.elementor-widget-shortcode > div > div > div > div > img.path3-light")]
        public IWebElement HomeFlowerSeven { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#post-3175 > div > div > section.elementor-section.elementor-top-section.elementor-element.elementor-element-2ab0397f.section-insights.elementor-section-boxed.elementor-section-height-default.elementor-section-height-default > div > div > div > div.elementor-element.elementor-element-465f274.fc-invertedsm.elementor-widget.elementor-widget-shortcode > div > div > div > div")]
        public IWebElement HomeFlowerEight { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#post-3175 > div > div > section.elementor-section.elementor-top-section.elementor-element.elementor-element-2ab0397f.section-insights.elementor-section-boxed.elementor-section-height-default.elementor-section-height-default > div > div > div > div.elementor-element.elementor-element-3bd4802.fc-insights.elementor-widget.elementor-widget-shortcode > div > div > div > div")]
        public IWebElement HomeFlowerNine { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#post-3175 > div > div > section.elementor-section.elementor-top-section.elementor-element.elementor-element-2ab0397f.section-insights.elementor-section-boxed.elementor-section-height-default.elementor-section-height-default > div > div > div > div.elementor-element.elementor-element-6c259f77.fc-insights-r.elementor-widget.elementor-widget-shortcode > div > div > div > div")]
        public IWebElement HomeFlowerTen { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#post-3175 > div > div > section.elementor-section.elementor-top-section.elementor-element.elementor-element-2ab0397f.section-insights.elementor-section-boxed.elementor-section-height-default.elementor-section-height-default > div > div > div > div.elementor-element.elementor-element-5632a9e4.fc-insights.elementor-widget.elementor-widget-shortcode > div > div > div > div")]
        public IWebElement HomeFlowerEleven { get; set; }


        //Footer Flower
        [FindsBy(How = How.CssSelector, Using = "#block-27 > div > div")]
        public IWebElement FooterFlowerOne { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#block-28 > div > div")]
        public IWebElement FooterFlowerTwo { get; set; }


        //About Us
        [FindsBy(How = How.CssSelector, Using = "#post-3181 > div > div > section.elementor-section.elementor-top-section.elementor-element.elementor-element-6b4fbeeb.section-rebrandbanner.left-margin.section-aboutbanner.elementor-section-boxed.elementor-section-height-default.elementor-section-height-default > div > div.elementor-column.elementor-col-50.elementor-top-column.elementor-element.elementor-element-19eac7e9.left-subh > div > div.elementor-element.elementor-element-7fe0ffe.bannerf-lite.med.elementor-widget.elementor-widget-shortcode > div > div > div > div")]
        public IWebElement AboutFlowerOne { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#post-3181 > div > div > section.elementor-section.elementor-top-section.elementor-element.elementor-element-8968bf1.section-feature-main.section-about.elementor-section-boxed.elementor-section-height-default.elementor-section-height-default > div > div > div > section > div > div.elementor-column.elementor-col-50.elementor-inner-column.elementor-element.elementor-element-319e346a > div > div.elementor-element.elementor-element-5e49ad8.bannerf-color.lg.elementor-widget.elementor-widget-shortcode > div > div > div > div")]
        public IWebElement AboutFlowerTwo { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#post-3181 > div > div > section.elementor-section.elementor-top-section.elementor-element.elementor-element-8968bf1.section-feature-main.section-about.elementor-section-boxed.elementor-section-height-default.elementor-section-height-default > div > div > div > section > div > div.elementor-column.elementor-col-50.elementor-inner-column.elementor-element.elementor-element-4490b7d2 > div > div.elementor-element.elementor-element-46c48486.sectionf-litemd.elementor-widget.elementor-widget-shortcode > div > div > div > div")]
        public IWebElement AboutFlowerThree { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#post-3181 > div > div > section.elementor-section.elementor-top-section.elementor-element.elementor-element-e4737a8.section-about.section-about2.elementor-section-boxed.elementor-section-height-default.elementor-section-height-default > div > div.elementor-column.elementor-col-50.elementor-top-column.elementor-element.elementor-element-1c495c62.col2 > div > div.elementor-element.elementor-element-3a15abda.sectionf-litemd-b.elementor-widget.elementor-widget-shortcode > div > div > div > div")]
        public IWebElement AboutFlowerFour { get; set; }


        //Our Expertise
        [FindsBy(How = How.CssSelector, Using = "#post-3184 > div > div > section.elementor-section.elementor-top-section.elementor-element.elementor-element-351a50e3.section-rebrandbanner.left-margin.section-expertisebanner.elementor-section-boxed.elementor-section-height-default.elementor-section-height-default > div > div.elementor-column.elementor-col-50.elementor-top-column.elementor-element.elementor-element-3451360e.left-subh > div > div.elementor-element.elementor-element-2f49d180.bannerf-lite.elementor-widget.elementor-widget-shortcode > div > div > div > div")]
        public IWebElement OurExpertiseOne { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#post-3184 > div > div > section.elementor-section.elementor-top-section.elementor-element.elementor-element-351a50e3.section-rebrandbanner.left-margin.section-expertisebanner.elementor-section-boxed.elementor-section-height-default.elementor-section-height-default > div > div.elementor-column.elementor-col-50.elementor-top-column.elementor-element.elementor-element-3451360e.left-subh > div > div.elementor-element.elementor-element-d3a5324.bannerf-color.elementor-widget.elementor-widget-shortcode > div > div > div > div")]
        public IWebElement OurExpertiseTwo { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#internal > div > div > div > section > div > div.elementor-column.elementor-col-50.elementor-inner-column.elementor-element.elementor-element-538536c0.col1 > div > div.elementor-element.elementor-element-7114d1e9.exp-flower.inex-com.elementor-widget.elementor-widget-shortcode > div > div > div > div")]
        public IWebElement OurExpertiseThree { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#transformation > div > div > div > section > div > div.elementor-column.elementor-col-50.elementor-inner-column.elementor-element.elementor-element-73c561d6 > div > div.elementor-element.elementor-element-d83c886.exp-flower.trans.elementor-widget.elementor-widget-shortcode > div > div > div > div")]
        public IWebElement OurExpertiseFour { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#post-3184 > div > div > section.elementor-section.elementor-top-section.elementor-element.elementor-element-6d006d0a.section-services.elementor-section-boxed.elementor-section-height-default.elementor-section-height-default > div > div > div > div.elementor-element.elementor-element-15df1e5d.exp-flower.quick.elementor-widget.elementor-widget-shortcode > div > div > div > div")]
        public IWebElement OurExpertiseFive { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#event > div > div.elementor-column.elementor-col-50.elementor-top-column.elementor-element.elementor-element-27fb1f71 > div > div.elementor-element.elementor-element-d8b65d6.exp-flower.event.elementor-widget.elementor-widget-shortcode > div > div > div > div")]
        public IWebElement OurExpertiseSix { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#internal > div > div > div > div.elementor-element.elementor-element-481b7698.elementor-widget.elementor-widget-heading > div > h2")]
        public IWebElement OurExpertiseHighlightSentence { get; set; }


        //Insights
        [FindsBy(How = How.CssSelector, Using = "#primary > section > div > div:nth-child(1) > div:nth-child(2) > div > div.article-imgcontainer > div.img-container > a > img")]
        public IWebElement Blog1 { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#primary > section > div > div:nth-child(1) > div:nth-child(3) > div > div.article-imgcontainer > div.img-container > a > img")]
        public IWebElement Blog2 { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#primary > section > div > div:nth-child(1) > div:nth-child(4) > div > div.article-imgcontainer > div.img-container > a > img")]
        public IWebElement Blog3 { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#post-2549 > div > div > section > div > div.elementor-column.elementor-col-50.elementor-top-column.elementor-element.elementor-element-34c41b9e.left-subh > div > div.elementor-element.elementor-element-237a585.exp-flower.in-f.elementor-widget.elementor-widget-shortcode > div > div > div > div")]
        public IWebElement InsightsFlower { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#primary > section > div > div:nth-child(1) > div.col-sm-12 > h3")]
        public IWebElement InsightTitleBlog { get; set; }



        //Contact Us
        [FindsBy(How = How.CssSelector, Using = "#post-45 > div > div > section.elementor-section.elementor-top-section.elementor-element.elementor-element-376fe662.elementor-hidden-tablet.elementor-hidden-mobile.elementor-section-boxed.elementor-section-height-default.elementor-section-height-default > div > div > div > div.elementor-element.elementor-element-653a55b0.exp-flower.cf1.elementor-widget.elementor-widget-shortcode > div > div > div > div")]
        public IWebElement ContactFlower1 { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#post-45 > div > div > section.elementor-section.elementor-top-section.elementor-element.elementor-element-376fe662.elementor-hidden-tablet.elementor-hidden-mobile.elementor-section-boxed.elementor-section-height-default.elementor-section-height-default > div > div > div > div.elementor-element.elementor-element-71b6eb6d.exp-flower.cf3.elementor-widget.elementor-widget-shortcode > div > div > div > div")]
        public IWebElement ContactFlower2 { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#post-45 > div > div > section.elementor-section.elementor-top-section.elementor-element.elementor-element-376fe662.elementor-hidden-tablet.elementor-hidden-mobile.elementor-section-boxed.elementor-section-height-default.elementor-section-height-default > div > div > div > div.elementor-element.elementor-element-6689d9ae.exp-flower.cf2.elementor-widget.elementor-widget-shortcode > div > div > div > div")]
        public IWebElement ContactFlower3 { get; set; }

        [FindsBy(How = How.Name, Using = "your-name")]
        public IWebElement YourName { get; set; }

        [FindsBy(How = How.Name, Using = "your-comp")]
        public IWebElement YourCompany { get; set; }

        [FindsBy(How = How.Name, Using = "your-email")]
        public IWebElement YourEmail { get; set; }

        [FindsBy(How = How.Name, Using = "your-phone")]
        public IWebElement YourPhone { get; set; }
        
        [FindsBy(How = How.Name, Using = "your-message")]
        public IWebElement YourMessage { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#wpcf7-f480-p45-o1 > form > p > input")]
        public IWebElement SubmitButton { get; set; }




        [FindsBy(How = How.CssSelector, Using = "menu-item-90")]
        public IWebElement shd { get; set; }

        [FindsBy(How = How.CssSelector, Using = "menu-item-90")]
        public IWebElement gstrh { get; set; }

        [FindsBy(How = How.CssSelector, Using = "menu-item-90")]
        public IWebElement hdfgh { get; set; }



    }
}
