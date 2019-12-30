import { AquaFarmingIoTTemplatePage } from './app.po';

describe('AquaFarmingIoT App', function() {
  let page: AquaFarmingIoTTemplatePage;

  beforeEach(() => {
    page = new AquaFarmingIoTTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
