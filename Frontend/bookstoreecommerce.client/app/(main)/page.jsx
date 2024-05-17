import Banner from "@/components/banner/banner";
import Advertising from "@/components/common/advertising";
import Articles from "@/components/article/articles";
import BookRecommendation from "@/components/book/book-recommendation";
import SubscribeEmail from "@/components/common/subscribe-email";

import { DUMMY_BOOKS } from "@/lib/constant/constantData";
import BookApi from "@/api/book";

const BOOK_API = new BookApi();

export default function HomePage() {
  //TODO
  const fetchBestSellerBook = async () => {
    const response = BOOK_API.getAllBook();
  };
  //TODO
  function fetchBestOfTheMonth() {}

  fetchBestSellerBook();
  return (
    <main>
      <Banner />
      <Advertising />
      <Articles />
      <BookRecommendation title="Best Seller" listBooks={DUMMY_BOOKS} />
      <BookRecommendation title="Best of the Month" listBooks={DUMMY_BOOKS} />
      <SubscribeEmail />
    </main>
  );
}
