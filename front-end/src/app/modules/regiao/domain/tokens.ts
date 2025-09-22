import { InjectionToken } from '@angular/core';
import { IRegiaoRepository } from './iregiao.repository';

export const REGIAO_REPOSITORY = new InjectionToken<IRegiaoRepository>('REGIAO_REPOSITORY');
