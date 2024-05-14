import Banner from "@/components/banner/banner";
import Advertising from "@/components/common/advertising";
import Articles from "@/components/article/articles";
import BookRecommendation from "@/components/book/book-recommendation";
import SubscribeEmail from "@/components/common/subscribe-email";

import { DUMMY_BOOKS } from "@/lib/constant/constantData";

export default function HomePage() {
  //TODO
  function fetchBestSellerBook() {}
  //TODO
  function fetchBestOfTheMonth() {}
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
