import Banner from "@/components/banner/banner";
import Advertising from "@/components/common/advertising";
import Articles from "@/components/article/articles";
import BookRecommendation from "@/components/book/book-recommendation";
import SubscribeEmail from "@/components/common/subscribe-email";

import { DUMMY_BOOKS } from "@/lib/constant/constantData";
import { getAllBook } from "@/api/book";

export default function HomePage() {
  //TODO
  const fetchBestSellerBook = async () => {
    const response = await getAllBook();
    const data = response.data.data;
    console.log(data);
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
