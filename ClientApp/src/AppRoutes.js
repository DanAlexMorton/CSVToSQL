import ApiAuthorzationRoutes from './components/api-authorization/ApiAuthorizationRoutes';
import { FetchData } from "./components/FetchData";

const AppRoutes = [
  {
    path: '/',
    requireAuth: true,
    element: <FetchData />
  },
  ...ApiAuthorzationRoutes
];

export default AppRoutes;
