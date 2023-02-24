export class ApiReturn {
  info?: Info;
  results?: Results[];

  constructor(obj: Partial<ApiReturn>) {
    Object.assign(this, obj);
  }
}

export class Info {
  count?: number;
  pages?: number;
  next?: string;
  prev?: string;

  constructor(obj: Partial<ApiReturn>) {
    Object.assign(this, obj);
  }
}

export class Results {
  name?: string;
  status?: string;
  species?: string;
  image?: string;

  constructor(obj: Partial<ApiReturn>) {
    Object.assign(this, obj);
  }
}
