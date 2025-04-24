import CartAndCheckoutHeader from "@/components/header-footer/cart-and-checkout-header";
import MainFooter from "@/components/header-footer/main-footer";

export default function OrderResultLayout({ children }) {
  return (
    <div>
      <CartAndCheckoutHeader />
      {children}
      <MainFooter />
    </div>
  );
}
