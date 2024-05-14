import { Guid } from "js-guid";

import articleImage1 from "@/assets/img/articleImage1.png";
import articleImage2 from "@/assets/img/articleImage2.png";

export const DUMMY_BOOKS = [
  {
    bookId: Guid.newGuid(),
    title: "Where the Crawdads Sing",
    author: "Delia Owens",
    originalPrice: 16.99,
    url: "/book-detail/where-the-crawdads-sing",
    imageUrl:
      "https://s3-alpha-sig.figma.com/img/f9e4/42c7/f4808e98ba531d64c0dff57f7d2c3922?Expires=1716163200&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4&Signature=CBvZnR15JE2wMzQ4ZIMDxV4I2ans6uyeZouIKzwoIpWz8aeVtUuWylTv5a4A7AGJRuTeOHFIuYDGePYyvUhbjbZMgiSIFBSCeCt19AcBoqvXB07f-3rZEvWfkjXVykyRANzm~Lf7nlSdijaxb6GNmcXG8lyntQwxcIx85OkbHA4vAIRCS6AtImoVY8SGITqVTKCL8PUY-d8tfBEEpcoLUrA8AgaYbtU33MYJ8rxz9eV~cvBtMDpEGy8DWCT3ZYdkQ9orjf-B8srJ8NFoeqw76iskyu-bdRmKjuwYjrWcVmX-v77CtHhO4qt~~5s33raqktwkkj-y1H-uOCFSWPsfOg__",
    description:
      "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
    rating: 4.8,
    ratingCounter: 105,
  },
  {
    bookId: Guid.newGuid(),
    title: "Introduction to Algorithms",
    author: "Thomas H. Cormen",
    originalPrice: 16.99,
    url: "/book-detail/introduction-to-algorithms",
    imageUrl:
      "https://s3-alpha-sig.figma.com/img/8fc2/9edb/ddd8db13bb192848605c5eb55ca236d3?Expires=1716163200&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4&Signature=nEK2cp1DqH9lWm-t7VnLivuigGkkqrcnw2xWUjH65ggkQKU~lPnqSJsjeL8zAniaBFU196buSycLP5y3yL1mywlDIPXKzPO6QDRJeeiuqyxg5lQmaQvr4wJIMSBIYe9IsALIj5PBJPVc7itX-G7GItpwMhD~61ltU--eLIrPiRNdhlgofhKImYnCNuMluipIWoioJraygFGNXr48SEH3ft5EQ1PwegRVRzjQtWfLUEhR3c4Jmp0azpMTWsSqcRmKxboQefCKZQr-RadHRn9vfQQA6URI3NFDqeDkDoBqbyCBxCWUky74V34nxY5A0wxGK9E5IouecyTn30OKJd5mTQ__",
    description:
      "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
    rating: 4.8,
    ratingCounter: 105,
  },
  {
    bookId: Guid.newGuid(),
    title: "Maybe You Should Talk to Someone",
    author: "Lori Gottlieb",
    originalPrice: 16.99,
    url: "/book-detail/maybe-you-should-talk-to-someone",
    imageUrl:
      "https://s3-alpha-sig.figma.com/img/d382/ffe7/14d53687669880646de466095672a60c?Expires=1716163200&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4&Signature=b~QhiYL212syowaBO7x2CJWlsSt~WNcru6m43QizULA8~BvKwYGNHW0vKAXRdFhRG5XUtmSpwDCDFYYWAHGY2gvn7HVhhliGzNa6BgkbUxq1kmMd88I~1OORzpJgmNaMTErorebnQA6EppFQP7MsGCp9Wiu7X1LsXYIwsdZ2ST6oCK3KoZejMIhX9Es93VaCAF0jDZ6IK0NJbf2Exo6F8qqDqeA4otFXAr7aCvBnVnMakq0s0glL8-b6UnMEqD3wkhH7GUeLMxaofy4Zb7vQdpibaKp~KjsMsW5noHyLOqdfn8~14PBY021FzU3~ZDVJ4Q5~eTbnQnZvrHIvDV5l8w__",
    description:
      "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
    rating: 4.8,
    ratingCounter: 105,
  },
  {
    bookId: Guid.newGuid(),
    title: "When We Believed in Mermaids",
    author: "Barbara O’Neal",
    originalPrice: 16.99,
    url: "/book-detail/when-we-believed-in-mermaids",
    imageUrl:
      "https://s3-alpha-sig.figma.com/img/ce20/c751/22212be8c4ed077fb6d1a5c029d616f6?Expires=1716163200&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4&Signature=dSKdBqPysBGOvPZ~Fp3ShPUanqlIuAqdwzmIrw7OQJIM6Z2idPSpcBTeF3mI1OqDi-oof9wO5PDKcCvmON~TjnNI7~9J3wyrxJf4OCbUV9HWW5kd7BrsWzPHr3YS5z9qAoWCwowLZQrlBit3hF8m4qiX1~jaLsyAT5b51yVf-EqH2OGW3WhdX13oCVSeryv1Fq42EnF8gJ5JforvIEEZeReu3VSUtAGUDBPMvc6hv9uPeQ2utEJEtMRJIZ4iuqBq7zXkz2qfxHEh6sHoNbYf9gAIYCIkWfbl-jtU5Dmyn2-jNyeL~3sgaZl09tNd2NZtsXtkM~P99-8SJS6T~Bh4jw__",
    description:
      "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
    rating: 4.8,
    ratingCounter: 105,
  },
  {
    bookId: Guid.newGuid(),
    title: "The Pale-Faced Lie",
    author: "David Crow",
    originalPrice: 16.99,
    url: "/book-detail/the-pale-faced-lie",
    imageUrl:
      "https://s3-alpha-sig.figma.com/img/5e2c/c494/4bb632fc791ce7b3b0a6677d54ee06fb?Expires=1716163200&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4&Signature=ER7K9yrHzMgNAQfZZYCpceu46eUoIEF~LntEFVpCH5W9a95w2mu7c-y2A6ZFaIUHrAb4Q9U11pDbR5pEsdbpOX8oC~Kzh0q9cAOqkTVYxyodjkZg6sFYdxK8PmFNyoIfqhjI-TK~CsSdQAvzluaVdJzxWNidVsI6Usx-2rS5XJFEeMWCfVmvAEbKXlWfshKsgYsdAA0z~fTdeHPbcWe32oVGZ9tEZfqlJdsc-pyDtIDINmU35DxxQrGSA2K6Zu6Gxo8b8HdLwM2MBcKsIlrbiGqRAYakCxOtKSCJUdIuvDcnfCTgt7hK9pf-YJMB2cfqNUfdbweh4WgypDhYUvBr9w__",
    description:
      "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
    rating: 4.8,
    ratingCounter: 105,
  },
];

export const DUMMY_CATEGORIES = [
  {
    categoryId: Guid.newGuid(),
    name: "All Books",
    description: "Description",
    url: "/all-books",
    quantity: 100,
  },
  {
    categoryId: Guid.newGuid(),
    name: "Art & Music",
    description: "Description",
    url: "/art-and-music",
    quantity: 100,
  },
  {
    categoryId: Guid.newGuid(),
    name: "Biographies",
    description: "Description",
    url: "/Biographies",
    quantity: 100,
  },
  {
    categoryId: Guid.newGuid(),
    name: "Kids",
    description: "Description",
    url: "/kids",
    quantity: 100,
  },
  {
    categoryId: Guid.newGuid(),
    name: "Comics",
    description: "Description",
    url: "/Comics",
    quantity: 100,
  },
  {
    categoryId: Guid.newGuid(),
    name: "Tech",
    description: "Description",
    url: "/tech",
    quantity: 100,
  },
];

export const DUMMY_ARTICLES = [
  {
    title: "Best Books of 2024",
    description:
      "If you need a new book to add to your reading list, look no further than this roundup of the best books that came out this year. We’ve been spoiled with amazing reads lately, so if you’re in the market for a hot-off-the-presses page-turner in any genre you can imagine, we’ve revealed the best books 2020 has to offer.",
    url: "/article/best-of-book-2024",
    image: articleImage1,
  },
  {
    title: "Why You Should Read Every Day",
    description:
      "When was the last time you read a book, or a substantial magazin article? Do your daily reading habits center around tweets, Facebook updates, or the directions on your instant oatmeal packet? <br/> Reading has a significant number of benefits, and here’re 10 benefits of reading to get you start reading",
    url: "/article/why-you-should-read-every-day",
    image: articleImage2,
  },
];

export const DUMMY_REVIEWS = {
  averageScore: 4.8,
  totalReviews: 15,
  reviews: [
    {
      reviewId: Guid.newGuid(),
      userName: "Thuan Tran",
      comment:
        "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
      rating: 3,
      dateCreated: new Date("2024-03-25"),
    },
    {
      reviewId: Guid.newGuid(),
      userName: "Thuan Tran",
      comment:
        "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
      rating: 4,
      dateCreated: new Date("2024-03-25"),
    },
    {
      reviewId: Guid.newGuid(),
      userName: "Thuan Tran",
      comment:
        "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
      rating: 5,
      dateCreated: new Date("2024-03-25"),
    },
    {
      reviewId: Guid.newGuid(),
      userName: "Thuan Tran",
      comment:
        "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
      rating: 3,
      dateCreated: new Date("2024-03-25"),
    },
    {
      reviewId: Guid.newGuid(),
      userName: "Thuan Tran",
      comment:
        "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
      ratingScore: 1,
      dateCreated: new Date("2024-03-25"),
    },
  ],
};

export const DUMMY_SHIPPING_METHODS = [
  {
    id: Guid.newGuid(),
    name: "Standard",
    description: "Arrives in 7 - 10 days",
    price: 0,
  },
  {
    id: Guid.newGuid(),
    name: "Fast",
    description: "Arrives in 4 - 7 days",
    price: 4.99,
  },
  {
    id: Guid.newGuid(),
    name: "Express",
    description: "Arrives in 1 - 3 days",
    price: 8.99,
  },
];

export const DUMMY_PAYMENT_METHODS = [
  {
    id: Guid.newGuid(),
    methodName: "Cash Payment On Delivery (Ship COD)",
  },
  {
    id: Guid.newGuid(),
    methodName: "Pay with international cards Visa, Master, JCB",
  },
];
